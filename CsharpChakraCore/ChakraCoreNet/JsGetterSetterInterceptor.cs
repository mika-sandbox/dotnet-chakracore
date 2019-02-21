namespace ChakraCoreNet
{
    public struct JsGetterSetterInterceptor
    {
        public JsValueRef GetTrap { get; set; }

        public JsValueRef SetTrap { get; set; }

        public JsValueRef DeletePropertyTrap { get; set; }

        public JsValueRef EnumerateTrap { get; set; }

        public JsValueRef OwnKeysTrap { get; set; }

        public JsValueRef HasTrap { get; set; }

        public JsValueRef GetOwnPropertyDescriptorTrap { get; set; }

        public JsValueRef DefinePropertyTrap { get; set; }

        public JsValueRef InitializerTrap { get; set; }
    }
}