using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "StringVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "String")]
	public sealed class StringVariable : BaseVariable<string>
	{
	}
}