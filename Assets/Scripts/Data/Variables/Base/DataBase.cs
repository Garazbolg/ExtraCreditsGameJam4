using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;


namespace Data
{
	[System.Serializable]
	public abstract class DataBase : ScriptableObject // , System.Runtime.Serialization.ISerializable
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";

		//public abstract void GetObjectData(SerializationInfo info, StreamingContext context);
#endif
	}
}
