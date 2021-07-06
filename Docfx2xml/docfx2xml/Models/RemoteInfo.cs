using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class RemoteInfo
  {
    /// <summary>
    /// the path to the source code file where the item is defined.
    /// </summary>
    [YamlMember(Alias = "path")]
    public string Path { get; set; }
    
    /// <summary>
    /// the branch of the source code.
    /// </summary>
    [YamlMember(Alias = "branch")]
    public string Branch { get; set; }
    
    /// <summary>
    /// the remote Git repository of the source code.
    /// </summary>
    [YamlMember(Alias = "repo")]
    public string Repo { get; set; }
  }
}
