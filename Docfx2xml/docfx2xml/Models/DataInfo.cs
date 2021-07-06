using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Docfx2xml.Models
{
  [Serializable]
  public class DataInfo
  {
    [YamlMember(Alias = "items")]
    public List<ItemInfo> Items { get; set; }

    [YamlMember(Alias = "references")]
    public List<ReferenceInfo> References { get; set; }
  }
}
