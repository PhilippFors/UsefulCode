using UnityEngine;

namespace UsefulCode.SOArchitecture
{
    /// <summary>
    /// Can be used to store either a type variable or a custom local constant value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [System.Serializable]
    public abstract class BaseReference<T, TVariable> : BaseReference where TVariable : BaseVariable<T>
    {
        public BaseReference()
        {
        }

        public BaseReference(T baseValue)
        {
            useConstantValue = true;
            constantValue = baseValue;
        }

        [SerializeField] private bool useConstantValue = false;

        [SerializeField] private T constantValue;

        [SerializeField] private TVariable variable;

        public TVariable Variable
        {
            get => variable;
            set
            {
                useConstantValue = false;
                variable = value;
            }
        }

        public T Value
        {
            get => useConstantValue || variable == null ? constantValue : variable.Value;
            set
            {
                if (!useConstantValue && variable != null)
                {
                    variable.Value = value;
                }
                else
                {
                    useConstantValue = true;
                    constantValue = value;
                }
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public abstract class BaseReference
    {
    }
}