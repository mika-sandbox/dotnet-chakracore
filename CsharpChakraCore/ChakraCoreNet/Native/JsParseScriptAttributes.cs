using System;

namespace ChakraCoreNet.Native
{
    [Flags]
    public enum JsParseScriptAttributes
    {
        None = 0x0,

        LibraryCode = 0x1,

        ArrayBufferIsUtf16Encoded = 0x2,

        StrictMode = 0x4
    }
}