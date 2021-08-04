using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "IntRuntimeSet.asset",
	    menuName = SOArchitecture_Folders.RUNTIMESET_SUBMENU + "Int"
	    )]
	public class IntRuntimeSet : RuntimeSet<int>
	{
	}
}