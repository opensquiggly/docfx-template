using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class SpecInfo
  {
    /// <summary>
    /// The unique identifier of the item.
    /// </summary>
    [YamlMember(Alias = "uid")]
    public string UId { get; set; }
    
    /// <summary>
    /// The display name of the item.
    /// </summary>
    [YamlMember(Alias = "name")]
    public string Name { get; set; }
    
    [YamlMember(Alias = "nameWithType")]
    public string NameWithType { get; set; }
    
    /// <summary>
    /// The full display name of the item. In programming languages, it's usually the full qualified name.
    /// </summary>
    [YamlMember(Alias = "fullName")]
    public string FullName { get; set; }
    
    [YamlMember(Alias = "isExternal")]
    public bool IsExternal { get; set; }
  }
}
