using System;

namespace ChakraCoreNet.Native
{
    public struct JsSourceContext
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public IntPtr Handle { get; private set; }

        public static JsSourceContext FromIntPtr(IntPtr ptr)
        {
            return new JsSourceContext { Handle = ptr };
        }

        public static JsSourceContext operator ++(JsSourceContext ptr)
        {
            ptr.Handle += 1;
            return ptr;
        }

        public static JsSourceContext None => new JsSourceContext { Handle = new IntPtr(-1) };
    }
}