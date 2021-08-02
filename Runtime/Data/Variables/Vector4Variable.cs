using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "Vector4Variable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Vector4")]
	public sealed class Vector4Variable : BaseVariable<Vector4>
	{
	}
}