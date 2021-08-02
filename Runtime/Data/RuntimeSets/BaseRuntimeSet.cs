using System;
using System.Collections;
using UnityEngine;

namespace Data
{
    /// <summary>
    /// Can contain anything at runtime and can be share across multiple places.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseRuntimeSet : ScriptableObject, IEnumerable
    {
        public object this[int index]
        {
            get => List[index];
            set => List[index] = value;
        }

        public int Count => List.Count;
        public abstract IList List { get; }
        public abstract Type Type { get; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}