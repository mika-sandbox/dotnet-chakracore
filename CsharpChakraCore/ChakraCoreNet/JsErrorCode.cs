namespace ChakraCoreNet
{
    // https://github.com/Microsoft/ChakraCore/blob/master/lib/Jsrt/ChakraCommon.h
    public enum JsErrorCode : uint
    {
        JsNoError = 0,

        JsErrorCategoryUsage = 0x10000,

        JsErrorInvalidArgument,

        JsErrorNullArgument,

        JsErrorNoCurrentContext,

        JsErrorInExceptionState,

        JsErrorNotImplemented,

        JsErrorWrongThread,

        JsErrorRuntimeInUse,

        JsErrorBadSerializedScript,

        JsErrorInDisabledState,

        JsErrorCannotDisableExecution,

        JsErrorHeapEnumInProgress,

        JsErrorArgumentNotObject,

        JsErrorInProfileCallback,

        JsErrorInThreadServiceCallback,

        JsErrorCannotSerializeDebugScript,

        JsErrorAlreadyDebuggingContext,

        JsErrorAlreadyProfilingContext,

        JsErrorIdleNotEnabled,

        JsCannotSetProjectionEnqueueCallback,

        JsErrorCannotStartProjection,

        JsErrorInObjectBeforeCollectCallback,

        JsErrorObjectNotInspectable,

        JsErrorPropertyNotSymbol,

        JsErrorPropertyNotString,

        JsErrorInvalidContext,

        JsInvalidModuleHostInfoKind,

        JsErrorModuleParsed,

        JsNoWeakRefRequired,

        JsErrorPromisePending,

        JsErrorModuleNotEvaluated,

        JsErrorCategoryEngine = 0x20000,

        JsErrorOutOfMemory,

        JsErrorBadFPUState,

        JsErrorCategoryScript = 0x30000,

        JsErrorScriptException,

        JsErrorScriptCompile,

        JsErrorScriptTerminated,

        JsErrorScriptEvalDisabled,

        JsErrorCategoryFatal = 0x40000,

        JsErrorFatal,

        JsErrorWrongRuntime,

        JsErrorCategoryDiagError = 0x50000,

        JsErrorDiagAlreadyInDebugMode,

        JsErrorDiagNotInDebugMode,

        JsErrorDiagNotAtBreak,

        JsErrorDiagInvalidHandle,

        JsErrorDiagObjectNotFound,

        JsErrorDiagUnableToPerformAction,

        JsSerializerNotSupported,

        JsTransferableNotSupported,

        JsTransferableAlreadyDetached
    }
}