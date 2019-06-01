using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Variables
{
	[System.Serializable]
	public class Vector3Variable : DataTypeBase<Vector3>{ }

	[System.Serializable]
	public class Vector3Reference : DataReference<Vector3,Vector3Variable>{ }
}