﻿using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  public class AttributeInfo
  {
    [YamlMember(Alias = "type")]
    public string Type { get; set; }
    
    [YamlMember(Alias = "ctor")]
    public string Ctor { get; set; }
    
    [YamlMember(Alias = "arguments")]
    public List<ArgumentInfo> Arguments { get; set; }
    
    [YamlMember(Alias = "namedArguments")]
    public List<ArgumentInfo> NamedArguments { get; set; }
  }
}