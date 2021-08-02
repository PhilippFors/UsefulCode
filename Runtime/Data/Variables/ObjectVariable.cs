using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "ObjectVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "UnityObject")]
	public sealed class ObjectVariable : BaseVariable<Object>
	{
	}
}