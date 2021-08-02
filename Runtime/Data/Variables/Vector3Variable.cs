using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "Vector3Variable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Vector3")]
	public sealed class Vector3Variable : BaseVariable<Vector3>
	{
	}
}