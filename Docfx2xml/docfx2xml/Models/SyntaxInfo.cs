using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class SyntaxInfo
  {
    [YamlMember(Alias = "content")]
    public string Content { get; set; }
    
    [YamlMember(Alias = "content.vb")]
    public string ContentVb { get; set; }
    
    [YamlMember(Alias = "parameters")]
    public List<ParameterInfo> Parameters { get; set; }
    
    [YamlMember(Alias = "return")]
    public ReturnInfo Return { get; set; }
  }
}
