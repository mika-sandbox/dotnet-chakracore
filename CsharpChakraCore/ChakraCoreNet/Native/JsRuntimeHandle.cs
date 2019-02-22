using System;

namespace ChakraCoreNet.Native
{
    public struct JsRuntimeHandle
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public IntPtr Handle { get; private set; }

        public static JsRuntimeHandle InvalidHandle => new JsRuntimeHandle { Handle = IntPtr.Zero };
    }
}