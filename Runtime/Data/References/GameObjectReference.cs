using UnityEngine;

namespace Data
{
	[System.Serializable]
	public class GameObjectReference : BaseReference<GameObject, GameObjectVariable>
	{
	    public GameObjectReference() : base() { }
	    public GameObjectReference(GameObject value) : base(value) { }
	}
}