using Data.Utility;
using UnityEngine;

namespace Data
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