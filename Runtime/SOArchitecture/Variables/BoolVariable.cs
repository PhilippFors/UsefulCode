using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "BoolVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Bool")]
	public sealed class BoolVariable : BaseVariable<bool>
	{
	}
}