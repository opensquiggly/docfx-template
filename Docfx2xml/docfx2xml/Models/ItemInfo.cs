using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class ItemInfo
  {
    [YamlMember(Alias = "uid")]
    public string UId { get; set; }
    
    [YamlMember(Alias = "commentId")]
    public string CommentId { get; set; }
    
    [YamlMember(Alias = "id")]
    public string Id { get; set; }
    
    [YamlMember(Alias = "parent")]
    public string Parent { get; set; }
    
    [YamlMember(Alias = "children")]
    public List<string> Children { get; set; }
    
    [YamlMember(Alias = "langs")]
    public List<string> Langs { get; set; }
    
    [YamlMember(Alias = "name")]
    public string Name { get; set; }

    [YamlMember(Alias = "nameWithType")]
    public string NameWithType { get; set; }

    [YamlMember(Alias = "fullName")]
    public string FullName { get; set; }

    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
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
