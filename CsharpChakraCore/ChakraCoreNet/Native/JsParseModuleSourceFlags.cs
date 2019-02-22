using System;

// ReSharper disable InconsistentNaming

namespace ChakraCoreNet.Native
{
    [Flags]
    public enum JsParseModuleSourceFlags
    {
        DataIsUTF16LE = 0x00000000,

        DataIsUTF8 = 0x00000001
    }
}