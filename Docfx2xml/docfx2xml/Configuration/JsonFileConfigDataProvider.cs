using System.IO;
using Newtonsoft.Json;

namespace Docfx2xml.Configuration
{
  public class JsonFileConfigDataProvider : ConfigDataProviderBase
  {
    private const string FILE_NAME = "convertConfig.json";
    
    protected override ConvertConfiguration GetConfigurationImplement()
    {
      if (File.Exists(FILE_NAME))
      {
        var result = JsonConvert.DeserializeObject<ConvertConfiguration>(File.ReadAllText(FILE_NAME));
        return result;
      }
      throw new FileNotFoundException(FILE_NAME);
    }
  }
}
