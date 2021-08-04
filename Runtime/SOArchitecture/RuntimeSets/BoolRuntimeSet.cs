using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "BoolRuntimeSet.asset",
	    menuName = SOArchitecture_Folders.RUNTIMESET_SUBMENU + "Bool"
	    )]
	public class BoolRuntimeSet : RuntimeSet<bool>
	{
	}
}