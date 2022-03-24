using System.Reflection;
using UnityEngine;

namespace UsefulCode.Utilities
{
    [DefaultExecutionOrder(-200)]
    public class MonoSingleton : MonoBehaviour
    {
    }
    
    /// <summary>
    /// Classes that need to be singletons can inherit from this class to avoid too much boilerplate code.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MonoSingleton<T> : MonoSingleton where T : MonoSingleton<T>
    {
        public static T Instance
        {
            get => instance == null ? instance = Initialize() : instance;
            protected set => instance = value;
        }
        
        private static T instance;
        
        private static SingletonFlags flags;
        
        static MonoSingleton()
        {
            ConfigureSingletonAttribute customAttribute = typeof (T).GetCustomAttribute<ConfigureSingletonAttribute>();
            flags = customAttribute != null ? customAttribute.Flags : SingletonFlags.None;
        }
        
        public static T Initialize()
        {
            if (flags.HasFlag(SingletonFlags.NoAutoInstance))
            {
                return FindObjectOfType<T>();
            }
            
            GameObject gameObject = new GameObject(typeof (T).FullName);
            T obj = gameObject.AddComponent<T>();
            
            if (flags.HasFlag(SingletonFlags.HideAutoInstance))
            {
                gameObject.hideFlags = HideFlags.HideAndDontSave;
            }

            if (!flags.HasFlag(SingletonFlags.PersistAutoInstance))
            {
                return obj;
            }

            DontDestroyOnLoad((UnityEngine.Object) gameObject);
            return obj;
        }

        private void Awake()
        {
            if (instance && flags.HasFlag(SingletonFlags.DestroyDuplicates) && instance != this)
            {
                Destroy(this);
            }
            else
            {
                if (flags.HasFlag(SingletonFlags.NoAwakeInstance) || instance && instance.isActiveAndEnabled && isActiveAndEnabled)
                {
                    return;
                }

                Instance = (T) this;
            }
        }
    }
}
