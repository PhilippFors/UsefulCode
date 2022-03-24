using System;
using JetBrains.Annotations;

namespace UsefulCode.Utilities
{
    [BaseTypeRequired(typeof (MonoSingleton<>))]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ConfigureSingletonAttribute : Attribute
    {
        public ConfigureSingletonAttribute(SingletonFlags flags) => this.Flags = flags;
        public SingletonFlags Flags { get; }
    }
}