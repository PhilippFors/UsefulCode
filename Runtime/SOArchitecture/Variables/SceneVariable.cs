using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
    [CreateAssetMenu(
        fileName = "SceneVariable.asset",
        menuName = SOArchitecture_Folders.ADVANCED_VARIABLE_SUBMENU + "Scene"
        )]
    public class SceneVariable : BaseVariable<SceneInfo>
    {
        public override SceneInfo Value => value;
        
        public override bool ReadOnly => true;
    }
}