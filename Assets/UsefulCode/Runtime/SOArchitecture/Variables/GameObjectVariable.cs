using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "GameObjectVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "GameObject")]
	public sealed class GameObjectVariable : BaseVariable<GameObject>
	{
	}
}