using UnityEngine;

namespace UsefulCode.SOArchitecture
{
	[System.Serializable]
	public class StringReference : BaseReference<string, StringVariable>
	{
	    public StringReference() : base() { }
	    public StringReference(string value) : base(value) { }
	}
}