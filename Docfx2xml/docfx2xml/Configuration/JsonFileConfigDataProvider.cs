using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Docfx2xml.Configuration
{
  public class JsonFileConfigDataProvider : IConfigDataProvider
  {
    private const string FILE_NAME = "convertConfig.json";

    public ConvertConfiguration GetConfiguration()
    {
      if (File.Exists(FILE_NAME))
      {
        return JsonConvert.DeserializeObject<ConvertConfiguration>(File.ReadAllText(FILE_NAME));
      }
      throw new FileNotFoundException(FILE_NAME);
    }

    public Task<ConvertConfiguration> GetConfigurationAsync() => Task.Run(GetConfiguration);
  }
}
