using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/ds/atcop/atcop_cops_auto_mode.txt", false, 0x81FF)]
    [Attributes(9)]
    public class AtcopCopsAutoModeTxt
    {
    }
}