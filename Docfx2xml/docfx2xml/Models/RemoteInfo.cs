using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class RemoteInfo
  {
    [YamlMember(Alias = "path")]
    public string Path { get; set; }
    
    [YamlMember(Alias = "branch")]
    public string Branch { get; set; }
    
    [YamlMember(Alias = "repo")]
    public string Repo { get; set; }
  }
}
