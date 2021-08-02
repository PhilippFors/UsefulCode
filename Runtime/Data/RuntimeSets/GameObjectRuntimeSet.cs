using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "GameObjectRuntimeSet.asset",
	    menuName = SOArchitecture_Folders.RUNTIMESET_SUBMENU + "GameObject"
	    )]
	public class GameObjectRuntimeSet : RuntimeSet<GameObject>
	{
	}
}