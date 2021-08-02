using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "BoolRuntimeSet.asset",
	    menuName = SOArchitecture_Folders.RUNTIMESET_SUBMENU + "Bool"
	    )]
	public class BoolRuntimeSet : RuntimeSet<bool>
	{
	}
}