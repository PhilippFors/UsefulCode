using UnityEngine;

namespace UsefulCode.SOArchitecture
{
    public abstract class BaseVaraible : ScriptableObject
    {
        public abstract bool ReadOnly { get; }
        public abstract bool Clampable { get; }
    }
    
    /// <summary>
    /// Simple ScriptableObject based variable which can be shared across any number of classes and scenes.
    /// An event can be used to subscribe to any changes to the value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseVariable<T> : BaseVaraible
    {
        public event System.Action<T> onValueChanged;
        public virtual T Value
        {
            get => value;
            set => SetValue(value);
        }
        
        public override bool Clampable => false;
        public override bool ReadOnly => readOnly;
        
        [SerializeField] protected T value = default(T);
        [SerializeField] private bool readOnly;
        [SerializeField] protected T minClampedValue = default(T);
        [SerializeField] protected T maxClampedValue = default(T);

        private bool raiseEventOnChange = true;
        
        public virtual T SetValue(BaseVariable<T> value)
        {
            return SetValue(value.Value);
        }

        public virtual T SetValue(T v, bool raiseEvent)
        {
            raiseEventOnChange = raiseEvent;
            v = SetValue(v);

            return v;
        }
        
        public virtual T SetValue(T v)
        {
            if (readOnly)
            {
                Debug.LogWarning($"The variable {name} is Read Only", this);
                return value;
            }
            
            if (Clampable)
            {
                v = ClampValue(v);
            }
            
            value = v;

            if (raiseEventOnChange)
            {
                onValueChanged?.Invoke(v);
            }
            
            raiseEventOnChange = true;
            
            return v;
        }

        protected virtual T ClampValue(T value)
        {
            return value;
        }

        public override string ToString()
        {
            return value == null ? "null" : value.ToString();
        }
    }
}
