using System;

namespace ChakraCoreNet
{
    public struct JsSourceContext
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public IntPtr Handle { get; set; }

        public static JsSourceContext FromIntPtr(IntPtr ptr)
        {
            return new JsSourceContext { Handle = ptr };
        }

        public static JsSourceContext operator ++(JsSourceContext ptr)
        {
            return new JsSourceContext { Handle = ptr.Handle + 1 };
        }
    }
}