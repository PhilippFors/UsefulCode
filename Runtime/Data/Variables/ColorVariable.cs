using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "ColorVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Color")]
	public sealed class ColorVariable : BaseVariable<Color>
	{
	}
}