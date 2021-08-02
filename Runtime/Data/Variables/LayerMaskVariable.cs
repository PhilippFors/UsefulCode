using Data.Utility;
using UnityEngine;

namespace Data
{
	[CreateAssetMenu(
	    fileName = "LayerMaskVariable.asset",
	    menuName = SOArchitecture_Folders.VARIABLE_SUBMENU + "LayerMask")]
	public sealed class LayerMaskVariable : BaseVariable<LayerMask>
	{
	}
}