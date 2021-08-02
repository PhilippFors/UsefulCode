using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "StringVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "String")]
	public sealed class StringVariable : BaseVariable<string>
	{
	}
}