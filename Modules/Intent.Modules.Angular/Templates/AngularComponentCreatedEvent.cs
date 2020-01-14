namespace Intent.Modules.Angular.Templates
{
    public static class AngularModuleCreatedEvent
    {
        public const string EventId = nameof(AngularModuleCreatedEvent);
        public const string ModelId = "ModelId";
        public const string ModuleId = "ModuleId";
    }

    public static class AngularComponentCreatedEvent
    {
        public const string EventId = "AngularComponentCreatedEvent";
        public const string ModelId = "ModelId";
        public const string ModuleId = "ModuleId";
    }

    public static class AngularServiceProxyCreatedEvent
    {
        public const string EventId = "AngularServiceProxyCreatedEvent";
        public const string ModelId = "ModelId";
        public const string ModuleId = "ModuleId";
    }

    public static class AngularConfigVariableRequiredEvent
    {
        public const string EventId = nameof(AngularConfigVariableRequiredEvent);
        public const string VariableId = nameof(VariableId);
        public const string DefaultValueId = nameof(DefaultValueId);
    }
}