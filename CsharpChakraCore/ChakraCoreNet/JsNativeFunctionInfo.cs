using System;

namespace ChakraCoreNet
{
    public struct JsNativeFunctionInfo
    {
        public IntPtr ThisArg { get; set; }

        public IntPtr NewTargetArg { get; set; }

        public bool IsConstructCall { get; set; }
    }
}