using System;

namespace ChakraCoreNet
{
    [Flags]
    public enum JsParseModuleSourceFlags
    {
        JsParseModuleSourceFlags_DataIsUTF16LE = 0x00000000,

        JsParseModuleSourceFlags_DataIsUTF8 = 0x00000001
    }
}