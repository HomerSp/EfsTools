using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5449)]
    [Attributes(9)]
    public class DcCal
    {
        [ElementsCount(2)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
        
    }
}
