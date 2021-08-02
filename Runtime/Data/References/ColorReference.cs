using UnityEngine;

namespace Data
{
	[System.Serializable]
	public class ColorReference : BaseReference<Color, ColorVariable>
	{
	    public ColorReference() : base() { }
	    public ColorReference(Color value) : base(value) { }
	}
}