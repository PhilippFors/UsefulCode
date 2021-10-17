using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "Vector4Variable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Vector4")]
	public sealed class Vector4Variable : BaseVariable<Vector4>
	{
	}
}