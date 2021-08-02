using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "DoubleVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Double")]
	public sealed class DoubleVariable : BaseVariable<double>
	{
	}
}