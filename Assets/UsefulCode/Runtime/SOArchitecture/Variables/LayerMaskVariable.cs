using UnityEngine;
using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
	[CreateAssetMenu(
	    fileName = "LayerMaskVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "LayerMask")]
	public sealed class LayerMaskVariable : BaseVariable<LayerMask>
	{
	}
}