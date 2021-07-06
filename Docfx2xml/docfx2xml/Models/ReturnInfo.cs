using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ReturnInfo
  {
    /// <summary>
    /// The type of the item, such as class, method, etc.
    /// </summary>
    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
    [YamlMember(Alias = "description")]
    public string Description { get; set; }
  }
}
