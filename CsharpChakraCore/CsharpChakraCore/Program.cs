using System;
using System.Diagnostics;

using ChakraCoreNet;
using ChakraCoreNet.Native;

namespace CsharpChakraCore
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                var js = "(() => { return 'Hello, World!'; })()";

                var sourceContext = JsSourceContext.FromIntPtr(IntPtr.Zero);
                using (var runtime = new ChakraRuntime())
                {
                    ChakraCore.JsRun(JsValueRef.FromString(js), sourceContext++, JsValueRef.FromString(""), JsParseScriptAttributes.StrictMode, out var result);

                    Console.WriteLine(result.ToString());
                    Console.WriteLine(runtime.IsExecutionDisabled);
                    Console.WriteLine(runtime.MemoryLimit);
                    Console.WriteLine(runtime.MemoryUsage);

                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}