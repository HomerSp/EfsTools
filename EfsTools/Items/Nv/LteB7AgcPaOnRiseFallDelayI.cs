using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6554)]
    [Attributes(9)]
    public class LteB7AgcPaOnRiseFallDelay
    {
        [ElementsCount(2)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Value { get; set; }
        
    }
}
