using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "IntVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Int")]
	public sealed class IntVariable : BaseVariable<int>
	{
	}
}