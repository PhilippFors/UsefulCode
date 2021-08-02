using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "IntRuntimeSet.asset",
	    menuName = SOArchitecture_Folders.RUNTIMESET_SUBMENU + "Int"
	    )]
	public class IntRuntimeSet : RuntimeSet<int>
	{
	}
}