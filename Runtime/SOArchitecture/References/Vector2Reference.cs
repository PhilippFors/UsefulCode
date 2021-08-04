using UnityEngine;

namespace UsefulCode.SOArchitecture
{
	[System.Serializable]
	public class Vector2Reference : BaseReference<Vector2, Vector2Variable>
	{
	    public Vector2Reference() : base() { }
	    public Vector2Reference(Vector2 value) : base(value) { }
	}
}