using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "Vector2Variable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Vector2")]
	public sealed class Vector2Variable : BaseVariable<Vector2>
	{
	}
}