using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5311)]
    [Attributes(9)]
    public class Gsm1800RgiG0F2
    {
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
        
    }
}
