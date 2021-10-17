using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "GameObjectRuntimeSet.asset",
	    menuName = SOArchitecture_Folders.RUNTIMESET_SUBMENU + "GameObject"
	    )]
	public class GameObjectRuntimeSet : RuntimeSet<GameObject>
	{
	}
}