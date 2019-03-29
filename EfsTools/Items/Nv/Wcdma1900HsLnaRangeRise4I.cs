using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4763)]
    [Attributes(9)]
    public class Wcdma1900HsLnaRangeRise4
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Value { get; set; }
        
    }
}
