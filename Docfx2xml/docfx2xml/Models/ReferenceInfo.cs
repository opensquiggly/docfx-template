using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ReferenceInfo
  {
    /// <summary>
    /// The unique identifier of the item.
    /// </summary>
    [YamlMember(Alias = "uid")]
    public string UId { get; set; }
    
    [YamlMember(Alias = "commentId")]
    public string CommentId { get; set; }

    /// <summary>
    /// The UID of the item's parent. If omitted, metadata parser will try to figure out its parent from the children information of other items within the same file.
    /// </summary>
    [YamlMember(Alias = "parent")]
    public string Parent { get; set; }
    
    [YamlMember(Alias = "isExternal")]
    public bool IsExternal { get; set; }
    
    [YamlMember(Alias = "definition")]
    public string Definition { get; set; }

    /// <summary>
    /// The display name of the item.
    /// </summary>
    [YamlMember(Alias = "name")]
    public string Name { get; set; }

    [YamlMember(Alias = "nameWithType")]
    public string NameWithType { get; set; }

    [YamlMember(Alias = "fullName")]
    public string FullName { get; set; }

    [YamlMember(Alias = "spec.csharp")]
    public List<SpecInfo> SpecCSharp { get; set; }
  }
}
