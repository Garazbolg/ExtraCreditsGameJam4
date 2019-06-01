
using UnityEngine;

namespace Data.Variables
{
	[CreateAssetMenu(fileName = "New Int Variable", menuName = "Variables/Base/Int")]
	[System.Serializable]
	public class IntVariable : DataTypeBase<int>
	{
		public void ApplyChange(int amount)
		{
			Value += amount;
		}
	}


	[System.Serializable]
	public class IntReference : DataReference<int, IntVariable> { }
}