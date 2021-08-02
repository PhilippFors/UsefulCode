using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "GameObjectVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "GameObject")]
	public sealed class GameObjectVariable : BaseVariable<GameObject>
	{
	}
}