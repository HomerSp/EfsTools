using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022025", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc10ExpHdetVsAgcV2
    {
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Value { get; set; }
        
    }
}
