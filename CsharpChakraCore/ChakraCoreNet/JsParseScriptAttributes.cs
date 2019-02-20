using System;

namespace ChakraCoreNet
{
    [Flags]
    public enum JsParseScriptAttributes
    {
        JsParseScriptAttributeNone = 0x0,

        JsParseScriptAttributeLibraryCode = 0x1,

        JsParseScriptAttributeArrayBufferIsUtf16Encoded = 0x2,

        JsParseScriptAttributeStrictMode = 0x4
    }
}