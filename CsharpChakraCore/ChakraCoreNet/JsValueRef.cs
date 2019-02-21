using System;

namespace ChakraCoreNet
{
    public struct JsValueRef
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public IntPtr Handle { get; }

        public static JsValueRef FromString(string str)
        {
            ChakraCore.JsCreateString(str.ToCharArray(), (ulong) str.ToCharArray().Length, out var value);
            return value;
        }
    }
}