using System;

namespace ChakraCoreNet.Native
{
    public struct JsContextRef
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public IntPtr Handle { get; private set; }

        public static JsContextRef InvalidRef => new JsContextRef { Handle = IntPtr.Zero };
    }
}