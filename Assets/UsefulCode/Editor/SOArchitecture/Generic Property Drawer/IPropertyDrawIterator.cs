using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UsefulCode.SOArchitecture.Editor.Generic_Property_Drawer
{
    public interface IPropertyDrawIterator : IPropertyIterator
    {
        void Draw();
    } 
}
