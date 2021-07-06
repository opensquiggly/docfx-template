using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ReturnInfo
  {
    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
    [YamlMember(Alias = "description")]
    public string Description { get; set; }
  }
}
