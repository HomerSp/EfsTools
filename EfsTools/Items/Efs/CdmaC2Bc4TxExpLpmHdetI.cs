using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023745", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc4TxExpLpmHdet
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte LpmEnable { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort LpmOffset { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort LpmSpan { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort LpmThreshold { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort LpmTxagcStart { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] LpmHdetVsAgcTable { get; set; }
        
    }
}
