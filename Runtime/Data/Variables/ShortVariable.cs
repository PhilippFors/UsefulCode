using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "ShortVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Short")]
	public sealed class ShortVariable : BaseVariable<short>
	{
	}
}