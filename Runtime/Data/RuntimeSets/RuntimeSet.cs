using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RuntimeSet<T> : BaseRuntimeSet, IEnumerable<T>
    {
        public new T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public override IList List => list;
        public override Type Type => typeof(T);
        public bool UniqueObjectsOnly => uniqueObjectsOnly;
        
        [SerializeField] private List<T> list = new List<T>();
        [SerializeField] private bool uniqueObjectsOnly;

        public void Add(T obj)
        {
            if (uniqueObjectsOnly)
            {
                if (list.Contains(obj))
                {
                    return;
                }
            }
            
            list.Add(obj);
        }

        public void Remove(T obj)
        {
            if (list.Contains(obj))
            {
                list.Remove(obj);
            }
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T obj) => list.Contains(obj);

        public void RemoveAt(int index) => list.RemoveAt(index);

        public void Insert(int index, T obj) => list.Insert(index, obj);

        public void InsertRange(int index, T[] obj) => list.InsertRange(index, obj);
        
        public void InsertRange(int index, List<T> obj) => list.InsertRange(index, obj);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public IEnumerator<T> GetEnumerator() => list.GetEnumerator();

        public override string ToString() => "Collection<" + typeof(T) + ">(" + Count + ")";
        
        public T[] ToArray() => list.ToArray();
    }
}
