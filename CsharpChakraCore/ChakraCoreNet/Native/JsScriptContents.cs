using System;

namespace ChakraCoreNet.Native
{
    public struct JsScriptContents
    {
        public IntPtr Container { get; set; }

        public JsScriptEncodingType EncodingType { get; set; }

        public JsScriptContainerType ContainerType { get; set; }

        public JsSourceContext SourceContext { get; set; }

        public ulong ContentLengthInBytes { get; set; }

        public string FullPath { get; set; }
    }
}