using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class SourceInfo
  {
    
    [YamlMember(Alias = "remote")]
    public RemoteInfo Remote { get; set; }
    
    [YamlMember(Alias = "id")]
    public string Id { get; set; }
    
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
    
    /// <summary>
    /// the Git revision of the source code.
    /// </summary>
    [YamlMember(Alias = "revision")]
    public string Revision { get; set; }
    
    /// <summary>
    /// the start line of the item definition.
    /// </summary>
    [YamlMember(Alias = "startLine")]
    public string StartLine { get; set; }
    
    /// <summary>
    ///  the end line of the item definition.
    /// </summary>
    [YamlMember(Alias = "endLine")]
    public string EndLine { get; set; }
  }
}
