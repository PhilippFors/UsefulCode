using UnityEngine;

namespace UsefulCode.SOArchitecture
{
	[System.Serializable]
	public class ObjectReference : BaseReference<Object, ObjectVariable>
	{
	    public ObjectReference() : base() { }
	    public ObjectReference(Object value) : base(value) { }
	}
}