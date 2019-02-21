using System;
using System.Diagnostics;

using ChakraCoreNet;

namespace CsharpChakraCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var js = "(() => { return 'Hello, World!'; })()";
                var sourceContext = JsSourceContext.FromIntPtr(IntPtr.Zero);

                ChakraCore.JsCreateRuntime(JsRuntimeAttributes.JsRuntimeAttributeNone, null, out var runtime);
                ChakraCore.JsCreateContext(runtime, out var context);
                ChakraCore.JsSetCurrentContext(context);

                ChakraCore.JsRun(JsValueRef.FromString(js), sourceContext++, JsValueRef.FromString(""), JsParseScriptAttributes.JsParseScriptAttributeStrictMode, out var result);

                ChakraCore.JsConvertValueToString(result, out var jsStr);
                ChakraCore.JsCopyStringUtf16(jsStr, 0, int.MaxValue, IntPtr.Zero, out var len);

                var str = new string(' ', (int) len + 1);
                ChakraCore.JsCopyStringUtf16(jsStr, 0, (int) len + 1, str, out _);

                Console.WriteLine(str);
                Console.ReadLine();

                ChakraCore.JsSetCurrentContext(context);
                ChakraCore.JsDisposeRuntime(runtime);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}