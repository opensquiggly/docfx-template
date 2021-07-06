using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ParameterInfo
  {
    [YamlMember(Alias = "id")]
    public string Id { get; set; }
    
    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
    [YamlMember(Alias = "description")]
    public string Description { get; set; }
    
    [YamlMember(Alias = "attributes")]
    public List<AttributeInfo> Attributes { get; set; }
  }
}
