using UnityEngine;

namespace UsefulCode.SOArchitecture
{
	[System.Serializable]
	public class GameObjectReference : BaseReference<GameObject, GameObjectVariable>
	{
	    public GameObjectReference() : base() { }
	    public GameObjectReference(GameObject value) : base(value) { }
	}
}