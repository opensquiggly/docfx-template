using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ItemInfo
  {
    /// <summary>
    /// The unique identifier of the item.
    /// </summary>
    [YamlMember(Alias = "uid")]
    public string UId { get; set; }
    
    [YamlMember(Alias = "commentId")]
    public string CommentId { get; set; }
    
    /// <summary>
    /// The identifier of the item.
    /// </summary>
    [YamlMember(Alias = "id")]
    public string Id { get; set; }
    
    /// <summary>
    /// The UID of the item's parent. If omitted, metadata parser will try to figure out its parent from the children information of other items within the same file.
    /// </summary>
    [YamlMember(Alias = "parent")]
    public string Parent { get; set; }
    
    /// <summary>
    ///  A list of UIDs of the item's children. Can be omitted if there are no children.
    /// </summary>
    [YamlMember(Alias = "children")]
    public List<string> Children { get; set; }
    
    [YamlMember(Alias = "langs")]
    public List<string> Langs { get; set; }
    
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

    /// <summary>
    /// The type of the item, such as class, method, etc.
    /// </summary>
    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
    /// <summary>
    /// 	The source code information of the item.
    /// </summary>
    [YamlMember(Alias = "source")]
    public SourceInfo Source { get; set; }
    
    [YamlMember(Alias = "assemblies")]
    public List<string> Assemblies { get; set; }
    
    [YamlMember(Alias = "namespace")]
    public string NameSpace { get; set; }
    
    [YamlMember(Alias = "syntax")]
    public SyntaxInfo Syntax { get; set; }
    
    [YamlMember(Alias = "inheritance")]
    public List<string> Inheritance { get; set; }
    
    [YamlMember(Alias = "implements")]
    public List<string> Implements { get; set; }
    
    [YamlMember(Alias = "inheritedMembers")]
    public List<string> InheritedMembers { get; set; }
    
    [YamlMember(Alias = "attributes")]
    public List<AttributeInfo> Attributes { get; set; }
    
    [YamlMember(Alias = "modifiers.csharp")]
    public List<string> ModifiersCSharp { get; set; }
    
    [YamlMember(Alias = "modifiers.vb")]
    public List<string> ModifiersVb { get; set; }
    
    [YamlMember(Alias = "overload")]
    public string Overload { get; set; }
    
    [YamlMember(Alias = "overridden")]
    public string Overridden { get; set; }
    
    [YamlMember(Alias = "summary")]
    public string Summary { get; set; }
    
    [YamlMember(Alias = "example")]
    public List<string> Example { get; set; }
  }
}
