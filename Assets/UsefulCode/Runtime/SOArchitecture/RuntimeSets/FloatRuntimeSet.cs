using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "FloatRuntimeSet.asset",
	    menuName = SOArchitecture_Folders.RUNTIMESET_SUBMENU + "Float"
	    )]
	public class FloatRuntimeSet : RuntimeSet<float>
	{
	}
}