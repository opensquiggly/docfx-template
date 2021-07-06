using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ArgumentInfo
  {
    /// <summary>
    /// The type of the item, such as class, method, etc.
    /// </summary>
    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
    [YamlMember(Alias = "value")]
    public string Value { get; set; }
  }
}
