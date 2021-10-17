using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "ShortVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Short")]
	public sealed class ShortVariable : BaseVariable<short>
	{
	}
}