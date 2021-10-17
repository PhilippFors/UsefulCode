using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "ObjectVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "UnityObject")]
	public sealed class ObjectVariable : BaseVariable<Object>
	{
	}
}