using System;
using System.Runtime.InteropServices;

namespace ChakraCoreNet.Native
{
    // from: https://github.com/Microsoft/ChakraCore/wiki/JavaScript-Runtime-%28JSRT%29-Reference
    public static class ChakraCore
    {
        private const string DllName = "ChakraCore.dll";

        #region externs

        #region ChakraCommon

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateRuntime(JsRuntimeAttributes attributes, JsThreadServiceCallback threadService, out JsRuntimeHandle runtime);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCollectGarbage(JsRuntimeHandle runtime);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDisposeRuntime(JsRuntimeHandle runtime);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetRuntimeMemoryUsage(JsRuntimeHandle runtime, out ulong memoryUsage);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetRuntimeMemoryLimit(JsRuntimeHandle runtime, out ulong memoryLimit);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetRuntimeMemoryLimit(JsRuntimeHandle runtime, ulong memoryLimit);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetRuntimeMemoryAllocationCallback(JsRuntimeHandle runtime, IntPtr callbackState, JsMemoryAllocationCallback allocationCallback);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetRuntimeBeforeCollectCallback(JsRuntimeHandle runtime, IntPtr callbackState, JsBeforeCollectCallback beforeCollectCallback);

        [DllImport(DllName)]
        public static extern JsErrorCode JsAddRef(JsRef @ref, out uint count);

        [DllImport(DllName)]
        public static extern JsErrorCode JsRelease(JsRef @ref, out uint count);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetObjectBeforeCollectCallback(JsRef @ref, IntPtr callbackState, JsObjectBeforeCollectCallback objectBeforeCollectCallback);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateContext(JsRuntimeHandle runtime, out JsContextRef newContext);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetCurrentContext(out JsContextRef currentContext);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetCurrentContext(JsContextRef context);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetContextOfObject(JsValueRef @object, out JsContextRef context);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetContextData(JsContextRef context, out IntPtr data);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetContextData(JsContextRef context, IntPtr data);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetRuntime(JsContextRef context, out JsRuntimeHandle runtime);

        [DllImport(DllName)]
        public static extern JsErrorCode JsIdle(out uint nextIdleTick);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetSymbolFromPropertyId(JsPropertyIdRef propertyId, out JsValueRef symbol);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetPropertyIdType(JsPropertyIdRef propertyId, out JsPropertyIdType propertyIdType);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetPropertyIdFromSymbol(JsValueRef symbol, out JsPropertyIdRef propertyId);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateSymbol(JsValueRef description, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetOwnPropertySymbols(JsValueRef @object, out JsValueRef propertySymbols);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetUndefinedValue(out JsValueRef undefinedValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetNullValue(out JsValueRef nullValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetTrueValue(out JsValueRef trueValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetFalseValue(out JsValueRef falseValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsBoolToBoolean(bool value, out JsValueRef booleanValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsBooleanToBool(JsValueRef value, out bool boolValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsConvertValueToBoolean(JsValueRef value, out JsValueRef booleanValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetValueType(JsValueRef value, out JsValueType type);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDoubleToNumber(double doubleValue, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsIntToNumber(int intValue, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsNumberToDouble(JsValueRef value, out double doubleValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsNumberToInt(JsValueRef value, out int intValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsConvertValueToNumber(JsValueRef value, out JsValueRef numberValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetStringLength(JsValueRef stringValue, out int length);

        [DllImport(DllName)]
        public static extern JsErrorCode JsConvertValueToString(JsValueRef value, out JsValueRef stringValue);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetGlobalObject(out JsValueRef globalObject);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateObject(out JsValueRef @object);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateExternalObject(IntPtr data, JsFinalizeCallback finalizeCallback, out JsValueRef @object);

        [DllImport(DllName)]
        public static extern JsErrorCode JsConvertValueToObject(JsValueRef value, out JsValueRef @object);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetPrototype(JsValueRef @object, out JsValueRef prototypeObject);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetPrototype(JsValueRef @object, JsValueRef prototypeObject);

        [DllImport(DllName)]
        public static extern JsErrorCode JsInstanceOf(JsValueRef @object, JsValueRef constructor, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetExtensionAllowed(JsValueRef @object, out bool value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsPreventExtension(JsValueRef @object);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetProperty(JsValueRef @object, JsPropertyIdRef propertyId, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetOwnPropertyDescriptor(JsValueRef @object, JsPropertyIdRef propertyId, out JsValueRef propertyDescriptor);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetOwnPropertyNames(JsValueRef @object, out JsValueRef propertyNames);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetProperty(JsValueRef @object, JsPropertyIdRef propertyId, JsValueRef value, bool useStrictRules);

        [DllImport(DllName)]
        public static extern JsErrorCode JsHasProperty(JsValueRef @object, JsPropertyIdRef propertyId, out bool hasProperty);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDeleteProperty(JsValueRef @object, JsPropertyIdRef propertyId, bool useStrictRules, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDefineProperty(JsValueRef @object, JsPropertyIdRef propertyId, JsValueRef propertyDescriptor, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsHasIndexedProperty(JsValueRef @object, JsValueRef index, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetIndexedProperty(JsValueRef @object, JsValueRef index, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetIndexedProperty(JsValueRef @object, JsValueRef index, JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDeleteIndexedProperty(JsValueRef @object, JsValueRef index);

        [DllImport(DllName)]
        public static extern JsErrorCode JsHasIndexedPropertiesExternalData(JsValueRef @object, out bool value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetIndexedPropertiesExternalData(JsValueRef @object, out IntPtr data, out JsTypedArrayType arrayType, out uint elementLength);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetIndexedPropertiesToExternalData(JsValueRef @object, IntPtr data, JsTypedArrayType arrayType, uint elementLength);

        [DllImport(DllName)]
        public static extern JsErrorCode JsEquals(JsValueRef object1, JsValueRef object2, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsStrictEquals(JsValueRef object1, JsValueRef object2, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsHasExternalData(JsValueRef @object, out bool value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetExternalData(JsValueRef @object, out IntPtr externalData);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetExternalData(JsValueRef @object, IntPtr externalData);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateArray(uint length, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateArrayBuffer(uint byteLength, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateExternalArrayBuffer(IntPtr data, uint byteLength, JsFinalizeCallback finalizeCallback, IntPtr callbackState, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateTypedArray(JsTypedArrayType arrayType, JsValueRef byteArray, uint byteOffset, uint elementLength, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateDataView(JsValueRef arrayBuffer, uint byteOffset, uint byteLength, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetTypedArrayInfo(JsValueRef typedArray, out JsTypedArrayType arrayType, out JsValueRef arrayBuffer, out uint byteOffset, out uint byteLength);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetArrayBufferStorage(JsValueRef arrayBuffer, out IntPtr buffer, out uint bufferLength);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetTypedArrayStorage(JsValueRef typedArray, out IntPtr buffer, out uint bufferLength, out JsTypedArrayType arrayType, out int elementSize);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetDataViewStorage(JsValueRef dataView, out IntPtr buffer, out uint bufferLength);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCallFunction(JsValueRef function, JsValueRef[] arguments, ushort argumentCount, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsConstructObject(JsValueRef function, JsValueRef[] arguments, ushort argumentCount, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateFunction(JsNativeFunction nativeFunction, IntPtr callbackState, out JsValueRef function);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateNamedFunction(JsValueRef name, JsNativeFunction nativeFunction, IntPtr callbackState, out JsValueRef function);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateError(JsValueRef message, out JsValueRef error);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateRangeError(JsValueRef message, out JsValueRef error);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateReferenceError(JsValueRef message, out JsValueRef error);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateSyntaxError(JsValueRef message, out JsValueRef error);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateTypeError(JsValueRef message, out JsValueRef error);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateURIError(JsValueRef message, out JsValueRef error);

        [DllImport(DllName)]
        public static extern JsErrorCode JsHasException(out bool hasException);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetAndClearException(out JsValueRef exception);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetException(JsValueRef exception);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDisableRuntimeExecution(JsRuntimeHandle runtime);

        [DllImport(DllName)]
        public static extern JsErrorCode JsEnableRuntimeExecution(JsRuntimeHandle runtime);

        [DllImport(DllName)]
        public static extern JsErrorCode JsIsRuntimeExecutionDisabled(JsRuntimeHandle runtime, out bool isDisabled);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetPromiseContinuationCallback(JsPromiseContinuationCallback promiseContinuationCallback, IntPtr callbackState);

        [DllImport(DllName)]
        public static extern JsErrorCode JsQueueBackgroundParse_Experimental(JsScriptContents contents, out ulong dwBgParseCookie);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDiscardBackgroundParse_Experimental(ulong dwBgParseCookie, IntPtr buffer, out bool callerOwnsBuffer);

        [DllImport(DllName)]
        public static extern JsErrorCode JsExecuteBackgroundParse_Experimental(ulong dwBgParseCookie, JsValueRef script, JsSourceContext sourceContext, string url, JsParseScriptAttributes parseAttributes, JsValueRef parserState, out JsValueRef result);

        #endregion

        #region ChakraCore

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateEnhancedFunction(JsEnhancedNativeFunction nativeFunction, JsValueRef metadata, IntPtr callbackState, out JsValueRef function);

        [DllImport(DllName)]
        public static extern JsErrorCode JsInitializeModuleRecord(JsModuleRecord referencingModule, JsValueRef normalizedSpecifier, out JsModuleRecord moduleRecord);

        [DllImport(DllName)]
        public static extern JsErrorCode JsParseModuleSource(JsModuleRecord requestModule, JsSourceContext sourceContext, byte[] script, uint scriptLength, JsParseModuleSourceFlags sourceFlag, out JsValueRef exceptionValueRef);

        [DllImport(DllName)]
        public static extern JsErrorCode JsModuleEvaluation(JsModuleRecord requestModule, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetModuleHostInfo(JsModuleRecord requestModule, JsModuleHostInfoKind moduleHostInfo, IntPtr hostInfo);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetModuleHostInfo(JsModuleRecord requestModule, JsModuleHostInfoKind moduleHostInfo, out IntPtr hostInfo);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetAndClearExceptionWithMetadata(out JsValueRef metadata);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateString(char[] content, ulong length, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateStringUtf16(char[] content, ulong length, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCopyString(JsValueRef value, string buffer, ulong bufferSize, out ulong length);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCopyString(JsValueRef value, IntPtr buffer, ulong bufferSize, out ulong length);

        [DllImport(DllName, CharSet = CharSet.Unicode)]
        public static extern JsErrorCode JsCopyStringUtf16(JsValueRef value, int start, int length, string buffer, out ulong written);

        [DllImport(DllName, CharSet = CharSet.Unicode)]
        public static extern JsErrorCode JsCopyStringUtf16(JsValueRef value, int start, int length, IntPtr buffer, out ulong written);

        [DllImport(DllName)]
        public static extern JsErrorCode JsParse(JsValueRef script, JsSourceContext sourceContext, JsValueRef sourceUrl, JsParseScriptAttributes parseAttributes, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsRun(JsValueRef script, JsSourceContext sourceContext, JsValueRef sourceUrl, JsParseScriptAttributes parseAttributes, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreatePropertyId(string name, ulong length, out JsPropertyIdRef propertyId);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreatePropertyString(string name, ulong length, out JsValueRef propertyString);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCopyPropertyId(JsPropertyIdRef propertyId, char[] buffer, ulong bufferSize, out ulong length);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSerialize(JsValueRef script, out JsValueRef buffer, JsParseScriptAttributes parseAttributes);

        [DllImport(DllName)]
        public static extern JsErrorCode JsParseSerialized(JsValueRef buffer, JsSerializedLoadScriptCallback scriptLoadCallback, JsSourceContext sourceContext, JsValueRef sourceUrl, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsRunSerialized(JsValueRef buffer, JsSerializedLoadScriptCallback scriptLoadCallback, JsSourceContext sourceContext, JsValueRef sourceUrl, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetPromiseState(JsValueRef promise, out JsPromiseState state);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetPromiseResult(JsValueRef promise, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreatePromise(out JsValueRef promise, out JsValueRef resolveFunction, out JsValueRef rejectFunction);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateWeakReference(JsValueRef value, out JsWeakRef weakRef);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetWeakReferenceValue(JsWeakRef weakRef, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateSharedArrayBufferWithSharedContent(JsSharedArrayBufferContentHandle sharedContents, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetSharedArrayBufferContent(JsValueRef sharedArrayBuffer, out JsSharedArrayBufferContentHandle sharedContents);

        [DllImport(DllName)]
        public static extern JsErrorCode JsReleaseSharedArrayBufferContentHandle(JsSharedArrayBufferContentHandle sharedContents);

        [DllImport(DllName)]
        public static extern JsErrorCode JsHasOwnProperty(JsValueRef @object, JsPropertyIdRef propertyId, out bool hasOwnProperty);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCopyStringOneByte(JsValueRef value, int start, int length, out char[] buffer, out ulong written);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetDataViewInfo(JsValueRef dataView, out JsValueRef arrayBuffer, out uint byteOffset, out uint byteLength);

        [DllImport(DllName)]
        public static extern JsErrorCode JsLessThan(JsValueRef object1, JsValueRef object2, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsLessThanOrEqual(JsValueRef object1, JsValueRef object2, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateExternalObjectWithPrototype(IntPtr data, JsFinalizeCallback finalizeCallback, JsValueRef prototype, out JsValueRef @object);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateTracedExternalObject(IntPtr data, ulong inlineSlotSize, JsTraceCallback traceCallback, JsFinalizeCallback finalizeCallback, JsValueRef prototype, out JsValueRef @object);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCreateCustomExternalObject(IntPtr data, ulong inlineSlotSize, JsTraceCallback traceCallback, JsFinalizeCallback finalizeCallback, ref JsGetterSetterInterceptor getterSetterInterceptor, JsValueRef prototype, out JsValueRef @object);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetArrayForEachFunction(out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetArrayKeysFunction(out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetArrayValuesFunction(out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetArrayEntriesFunction(out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetPropertyIdSymbolIterator(out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetErrorPrototype(out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetIteratorPrototype(out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsIsConstructor(JsValueRef @object, out bool isConstructor);

        [DllImport(DllName)]
        public static extern JsErrorCode JsCloneObject(JsValueRef source, out JsValueRef clonedObject);

        [DllImport(DllName)]
        public static extern JsErrorCode JsPrivateHasProperty(JsValueRef @object, JsValueRef key, out bool hasProperty);

        [DllImport(DllName)]
        public static extern JsErrorCode JsPrivateGetProperty(JsValueRef @object, JsValueRef key, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsPrivateSetProperty(JsValueRef @object, JsValueRef key, JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsPrivateDeleteProperty(JsValueRef @object, JsValueRef key, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsObjectGetProperty(JsValueRef @object, JsValueRef key, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsObjectSetProperty(JsValueRef @object, JsValueRef key, JsValueRef value, bool useStrictRules);

        [DllImport(DllName)]
        public static extern JsErrorCode JsObjectHasProperty(JsValueRef @object, JsValueRef key, out bool hasProperty);

        [DllImport(DllName)]
        public static extern JsErrorCode JsObjectDefineProperty(JsValueRef @object, JsValueRef key, JsValueRef propertyDescriptor, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsObjectDefinePropertyFull(JsValueRef @object, JsValueRef key, JsValueRef value, JsValueRef getter, JsValueRef setter, bool writable, bool enumerable, bool configurable, out bool result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsObjectDeleteProperty(JsValueRef @object, JsValueRef key, bool useStrictRules, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsObjectGetOwnPropertyDescriptor(JsValueRef @object, JsValueRef key, out JsValueRef propertyDescriptor);

        [DllImport(DllName)]
        public static extern JsErrorCode JsObjectHasOwnProperty(JsValueRef @object, JsValueRef key, out bool hasOwnProperty);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetHostPromiseRejectionTracker(JsHostPromiseRejectionTrackerCallback promiseRejectionTrackerCallback, IntPtr callbackState);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetModuleNamespace(JsModuleRecord requestModule, out JsValueRef moduleNamespace);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetProxyProperties(JsValueRef @object, out bool isProxy, out JsValueRef target, out JsValueRef handler);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSerializeParserState(JsValueRef scriptVal, out JsValueRef bufferVal, JsParseScriptAttributes parseAttributes);

        [DllImport(DllName)]
        public static extern JsErrorCode JsRunScriptWithParserState(JsValueRef script, JsSourceContext sourceContext, JsValueRef sourceUrl, JsParseScriptAttributes parseAttributes, JsValueRef parserState, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDeserializeParserState(JsValueRef script, JsSourceContext sourceContext, JsValueRef sourceUrl, JsParseScriptAttributes parserAttributes, JsValueRef parserState, out JsValueRef result);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetRuntimeBeforeSweepCallback(JsRuntimeHandle runtimeHandle, IntPtr callbackState, JsBeforeSweepCallback beforeSweepCallback);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetRuntimeDomWrapperTracingCallbacks(JsRuntimeHandle runtimeHandle, JsRef wrapperTracingState, JsDOMWrapperTracingCallback wrapperTracingCallback, JsDOMWrapperTracingDoneCallback wrapperTracingDoneCallback,
                                                                                JsDOMWrapperTracingEnterFinalPauseCallback enterFinalPauseCallback);

        [DllImport(DllName)]
        public static extern JsErrorCode JsTraceExternalReference(JsRuntimeHandle runtimeHandle, JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsAllocRawData(JsRuntimeHandle runtimeHandle, ulong sizeInBytes, bool zeroed, out JsRef buffer);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarSerializer(ReallocateBufferMemoryFunc reallocateBufferMemory, WriteHostObjectFunc writeHostObject, IntPtr callbackState, out JsVarSerializerHandle serializerHandle);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarSerializerWriteRawBytes(JsVarSerializerHandle serializerHandle, IntPtr source, ulong length);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarSerializerWriteValue(JsVarSerializerHandle serializerHandle, JsValueRef rootObject);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarSerializerReleaseData(JsVarSerializerHandle serializerHandle, out byte[] data, out ulong dataLength);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarSerializerDetachArrayBuffer(JsVarSerializerHandle serializerHandle);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarSerializerSetTransferableVars(JsVarSerializerHandle serializerHandle, JsValueRef[] transferableVars, ulong transferableVarsCount);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarSerializerFree(JsVarSerializerHandle serializerHandle);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarDeserializer(IntPtr data, ulong size, ReadHostObjectFunc readHostObject, GetSharedArrayBufferFromIdFunc getSharedArrayBufferFromId, IntPtr callbackState, out JsVarDeserializerHandle deserializerHandle);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarDeserializerReadRawBytes(JsVarDeserializerHandle deserializerHandle, ulong length, out IntPtr data);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarDeserializerReadBytes(JsVarDeserializerHandle deserializerHandle, ulong length, out IntPtr data);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarDeserializerReadValue(JsVarDeserializerHandle deserializerHandle, out JsValueRef value);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarDeserializerSetTransferableVars(JsVarDeserializerHandle deserializerHandle, JsValueRef[] transferableVars, ulong transferableVarsCount);

        [DllImport(DllName)]
        public static extern JsErrorCode JsVarDeserializerFree(JsVarDeserializerHandle deserializerHandle);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetArrayBufferExtraInfo(JsValueRef arrayBuffer, out char extraInfo);

        [DllImport(DllName)]
        public static extern JsErrorCode JsSetArrayBufferExtraInfo(JsValueRef arrayBuffer, char extraInfo);

        [DllImport(DllName)]
        public static extern JsErrorCode JsDetachArrayBuffer(JsValueRef arrayBuffer);

        [DllImport(DllName)]
        public static extern JsErrorCode JsGetArrayBufferFreeFunction(JsValueRef arrayBuffer, out ArrayBufferFreeFn freeFn);

        #endregion

        #endregion

        #region callbacks

        public delegate JsValueRef JsEnhancedNativeFunction(JsValueRef callee, JsValueRef[] arguments, ushort argumentCount, JsNativeFunctionInfo info, IntPtr callbackState);

        public delegate JsErrorCode FetchImportedModuleCallBack(JsModuleRecord referencingModule, object specifier, out JsModuleRecord dependentModuleRecord);

        public delegate JsErrorCode FetchImportedModuleFromScriptCallBack(JsSourceContext dwReferencingSourceContext, JsValueRef specifier, out JsModuleRecord dependentModuleRecord);

        public delegate JsErrorCode NotifyModuleReadyCallback(JsModuleRecord referencingModule, JsValueRef exceptionVar);

        public delegate void JsHostPromiseRejectionTrackerCallback(JsValueRef promise, JsValueRef reason, bool handled, IntPtr callbackState);

        // ReSharper disable once InconsistentNaming
        public delegate void JsDOMWrapperTracingCallback(IntPtr data);

        // ReSharper disable once InconsistentNaming
        public delegate void JsDOMWrapperTracingDoneCallback(IntPtr data);

        // ReSharper disable once InconsistentNaming
        public delegate void JsDOMWrapperTracingEnterFinalPauseCallback(IntPtr data);

        public delegate void JsTraceCallback(IntPtr data);

        public delegate bool JsSerializedLoadScriptCallback(JsSourceContext sourceContext, out JsValueRef value, JsParseScriptAttributes parseAttributes);

        public delegate void JsBeforeSweepCallback(IntPtr callbackState);

        public delegate byte[] ReallocateBufferMemoryFunc(IntPtr state, byte[] oldBuffer, ulong newSize, out ulong allocatedSize);

        public delegate bool WriteHostObjectFunc(IntPtr state, IntPtr hostObject);

        public delegate bool JsMemoryAllocationCallback(IntPtr callbackState, JsMemoryEventType allocationEvent, ulong allocationSize);

        public delegate void JsBeforeCollectCallback(IntPtr callbackState);

        public delegate void JsObjectBeforeCollectCallback(JsRef @ref, IntPtr callbackState);

        public delegate void JsBackgroundWorkItemCallback(IntPtr callbackState);

        public delegate bool JsThreadServiceCallback(JsBackgroundWorkItemCallback callback, IntPtr callbackState);

        public delegate void JsSerializedScriptUnloadCallback(JsSourceContext sourceContext);

        public delegate void JsFinalizeCallback(IntPtr data);

        public delegate JsValueRef JsNativeFunction(JsValueRef callee, bool isConstructCall, JsValueRef[] arguments, ushort argumentCount, IntPtr callbackState);

        public delegate void JsPromiseContinuationCallback(JsValueRef task, IntPtr callbackState);

        public delegate JsValueRef ReadHostObjectFunc(IntPtr state);

        public delegate JsValueRef GetSharedArrayBufferFromIdFunc(IntPtr state, uint id);

        public delegate void ArrayBufferFreeFn(IntPtr ptr);

        #endregion
    }
}