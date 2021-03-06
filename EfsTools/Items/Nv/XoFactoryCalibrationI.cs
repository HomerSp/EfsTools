using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4954)]
    [Attributes(9)]
    public class XoFactoryCalibration
    {
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int C3 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int C2 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int C1 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int C0 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int T0 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int T0p { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int P { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort FtQualInd { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte XoTrim { get; set; }
        
    }
}
