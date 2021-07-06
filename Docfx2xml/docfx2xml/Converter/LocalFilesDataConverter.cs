using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Docfx2xml.Configuration;
using Docfx2xml.Helpers;
using Docfx2xml.Logger;
using Docfx2xml.Models;
using Docfx2xml.XmlConverter;
using YamlDotNet.Serialization;

namespace Docfx2xml.Converter
{
  public class LocalFilesDataConverter : IDataConverter
  {
    private readonly IConfigDataProvider _configDataProvider;
    private readonly ILogger _logger;
    private readonly IXmlConverter _xmlConverter;
    private readonly IDataLoader _dataLoader;
    
    public LocalFilesDataConverter(IConfigDataProvider configDataProvider, ILogger logger, IXmlConverter xmlConverter, IDataLoader dataLoader)
    {
      _configDataProvider = configDataProvider;
      _logger = logger;
      _xmlConverter = xmlConverter;
      _dataLoader = dataLoader;
    }

    public void Convert() => ConvertAsync().GetAwaiter().GetResult();

    public async Task ConvertAsync()
    {
      var config = await GetConfig();
      ConvertImplement(config);
    }

    private void ConvertImplement(ConvertConfiguration config)
    {
      var files = Directory.GetFiles(config.YamlDataPath, "*.yml");
      if (!files.Any())
      {
        throw new FileNotFoundException($"directory {config.YamlDataPath} not contains *.yml files");
      }
      DirectoryHelper.RecreateDirectory(config.XmlOutPath);
      
      var deserializer = new DeserializerBuilder()
        .IgnoreUnmatchedProperties()
        .Build();
      foreach (var file in files)
      {
        if (Path.GetFileName(file) == "toc.yml")
        {
          continue;
        }
        
        _logger.LogInformation($"Process: {file}...");
        
        using var readerYaml = new StreamReader(file);
        var yamlData = deserializer.Deserialize<DataInfo>(readerYaml);
        var xml = _xmlConverter.ConvertToDoc(yamlData, config.XsltFilePath);
        var xmlFileName = Path.GetFileNameWithoutExtension(file);
        
        _dataLoader.UploadData(xml, config, xmlFileName, null);
        
        _logger.LogInformation($"Saved {xmlFileName}.xml");
      }
      _logger.LogInformation("...");
      _logger.LogInformation($"Processed files:{files.Length}");
    }

    private async Task<ConvertConfiguration> GetConfig()
    {
      var config = await _configDataProvider.GetConfigurationAsync();
      if(string.IsNullOrEmpty(config?.XmlOutPath))
      {
        throw new ArgumentNullException(nameof(config.XmlOutPath));
      }
      if (string.IsNullOrEmpty(config.XsltFilePath))
      {
        throw new ArgumentNullException(nameof(config.XsltFilePath));
      }
      return config;
    }
  }
}
