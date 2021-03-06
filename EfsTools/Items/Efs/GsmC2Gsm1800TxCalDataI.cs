using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024978", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1800TxCalData
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte TxCalChanSize { get; set; }
        
        [ElementsCount(3)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] TxCalChan { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short AmamMaxDbm { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RgiForPred { get; set; }
        
        [ElementsCount(1)]
        [ElementType("Variant_Marker")]
        [Description("")]
        public VariantMarker VariantDataMarker { get; set; }
        
    }
}
