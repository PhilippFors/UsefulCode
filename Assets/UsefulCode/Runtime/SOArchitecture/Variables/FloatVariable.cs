using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "FloatVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "Float")]
	public sealed class FloatVariable : BaseVariable<float>
	{
	}
}