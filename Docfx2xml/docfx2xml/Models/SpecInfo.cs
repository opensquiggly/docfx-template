using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class SpecInfo
  {
    [YamlMember(Alias = "uid")]
    public string UId { get; set; }
    
    [YamlMember(Alias = "name")]
    public string Name { get; set; }
    
    [YamlMember(Alias = "nameWithType")]
    public string NameWithType { get; set; }
    
    [YamlMember(Alias = "fullName")]
    public string FullName { get; set; }
    
    [YamlMember(Alias = "isExternal")]
    public bool IsExternal { get; set; }
  }
}
