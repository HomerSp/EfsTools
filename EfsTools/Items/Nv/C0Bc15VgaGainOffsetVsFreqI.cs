using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4307)]
    [Attributes(9)]
    public class C0Bc15VgaGainOffsetVsFreq
    {
        [ElementsCount(48)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Value { get; set; }
        
    }
}
