using UsefulCode.SOArchitecture;
using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "ColorVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Color")]
	public sealed class ColorVariable : BaseVariable<Color>
	{
	}
}