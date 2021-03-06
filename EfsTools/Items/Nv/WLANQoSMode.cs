using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4122)]
    [Attributes(9)]
    public class WlanQosMode
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}