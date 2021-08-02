using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "FloatVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Float")]
	public sealed class FloatVariable : BaseVariable<float>
	{
	}
}