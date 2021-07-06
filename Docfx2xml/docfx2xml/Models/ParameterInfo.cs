using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ParameterInfo
  {
    /// <summary>
    /// The identifier of the item.
    /// </summary>
    [YamlMember(Alias = "id")]
    public string Id { get; set; }
    
    /// <summary>
    /// The type of the item, such as class, method, etc.
    /// </summary>
    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
    [YamlMember(Alias = "description")]
    public string Description { get; set; }
    
    [YamlMember(Alias = "attributes")]
    public List<AttributeInfo> Attributes { get; set; }
  }
}
