using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "BoolVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Bool")]
	public sealed class BoolVariable : BaseVariable<bool>
	{
	}
}