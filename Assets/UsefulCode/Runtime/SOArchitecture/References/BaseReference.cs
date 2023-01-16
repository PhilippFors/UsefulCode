using UnityEngine;
using UnityEngine.Serialization;

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
            useConstant = true;
            constantValue = baseValue;
        }

        [SerializeField] private bool useConstant = false;

        [SerializeField] private T constantValue;

        [SerializeField] private TVariable variable;

        public TVariable Variable
        {
            get => variable;
            set
            {
                useConstant = false;
                variable = value;
            }
        }

        public T Value
        {
            get => useConstant || variable == null ? constantValue : variable.Value;
            set
            {
                if (!useConstant && variable != null)
                {
                    variable.Value = value;
                }
                else
                {
                    useConstant = true;
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