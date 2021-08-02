using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Editor.Generic_Property_Drawer
{
    public interface IPropertyIterator
    {
        bool Next();
        void End();
    }

}