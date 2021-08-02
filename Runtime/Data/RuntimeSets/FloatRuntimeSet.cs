using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "FloatRuntimeSet.asset",
	    menuName = SOArchitecture_Folders.RUNTIMESET_SUBMENU + "Float"
	    )]
	public class FloatRuntimeSet : RuntimeSet<float>
	{
	}
}