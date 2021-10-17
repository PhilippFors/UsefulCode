using System;

namespace UsefulCode.Utilities
{
    [Flags]
    public enum SingletonFlags
    {
        None,
        NoAutoInstance,
        HideAutoInstance,
        NoAwakeInstance,
        PersistAutoInstance,
        DestroyDuplicates
    }
}