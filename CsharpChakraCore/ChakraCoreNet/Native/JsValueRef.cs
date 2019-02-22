using System;

namespace ChakraCoreNet.Native
{
    public struct JsValueRef
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public IntPtr Handle { get; }

        public static JsValueRef FromBoolean(bool b)
        {
            ChakraCore.JsBoolToBoolean(b, out var value);
            return value;
        }

        public static JsValueRef FromString(string str)
        {
            ChakraCore.JsCreateString(str.ToCharArray(), (ulong) str.ToCharArray().Length, out var value);
            return value;
        }

        public bool ToBool()
        {
            ChakraCore.JsBooleanToBool(this, out var b);
            return b;
        }

        public override string ToString()
        {
            ChakraCore.JsConvertValueToString(this, out var jsstr);
            ChakraCore.JsCopyStringUtf16(jsstr, 0, int.MaxValue, IntPtr.Zero, out var len);

            var str = new string(' ', (int) len + 1);
            ChakraCore.JsCopyStringUtf16(jsstr, 0, (int) len + 1, str, out _);
            return str;
        }
    }
}