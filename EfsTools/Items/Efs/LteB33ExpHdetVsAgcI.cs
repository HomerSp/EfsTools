using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024881", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33ExpHdetVsAgc
    {
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] ExpHdetVsAgc { get; set; }
        
    }
}
