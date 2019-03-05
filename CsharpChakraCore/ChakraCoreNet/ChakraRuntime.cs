using System;

using ChakraCoreNet.Native;

namespace ChakraCoreNet
{
    public class ChakraRuntime : IDisposable
    {
        private readonly JsContextRef _context;
        private readonly JsRuntimeHandle _runtime;

        public ulong MemoryUsage
        {
            get
            {
                ChakraCore.JsGetRuntimeMemoryUsage(_runtime, out var memoryUsage);
                return memoryUsage;
            }
        }

        public ulong MemoryLimit
        {
            get
            {
                ChakraCore.JsGetRuntimeMemoryLimit(_runtime, out var memoryLimit);
                return memoryLimit;
            }
            set => ChakraCore.JsSetRuntimeMemoryLimit(_runtime, value);
        }

        public bool IsExecutionDisabled
        {
            get
            {
                ChakraCore.JsIsRuntimeExecutionDisabled(_runtime, out var isDisabled);
                return isDisabled;
            }
        }

        public ChakraRuntime(JsRuntimeAttributes attributes = JsRuntimeAttributes.None)
        {
            ChakraCore.JsCreateRuntime(attributes, null, out _runtime);
            ChakraCore.JsCreateContext(_runtime, out _context);
            ChakraCore.JsSetCurrentContext(_context);
        }

        public void Dispose()
        {
            ChakraCore.JsSetCurrentContext(JsContextRef.InvalidRef);
            ChakraCore.JsDisposeRuntime(_runtime);
        }

        public void CollectGarbage()
        {
            ChakraCore.JsCollectGarbage(_runtime);
        }

        public void DisableExecution()
        {
            ChakraCore.JsDisableRuntimeExecution(_runtime);
        }

        public void EnableExecution()
        {
            ChakraCore.JsEnableRuntimeExecution(_runtime);
        }
    }
}