using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ArgumentInfo
  {
    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
    [YamlMember(Alias = "value")]
    public string Value { get; set; }
  }
}
