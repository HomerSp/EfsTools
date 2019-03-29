using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4569)]
    [Attributes(9)]
    public class BcxBlockExpHdetVsAgc
    {
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
        
    }
}
