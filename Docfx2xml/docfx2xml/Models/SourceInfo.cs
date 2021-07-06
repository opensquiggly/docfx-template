using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class SourceInfo
  {
    [YamlMember(Alias = "remote")]
    public RemoteInfo Remote { get; set; }
    
    [YamlMember(Alias = "id")]
    public string Id { get; set; }
    
    [YamlMember(Alias = "path")]
    public string Path { get; set; }
    
    [YamlMember(Alias = "startLine")]
    public string StartLine { get; set; }
  }
}
