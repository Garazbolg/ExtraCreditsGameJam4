
using UnityEngine;

namespace Data.Variables
{
	[CreateAssetMenu(fileName = "New Boolean Variable", menuName = "Variables/Base/Boolean")]
	public class BoolVariable : DataTypeBase<bool>
	{
		
		public void Toggle(){
			Value = !Value;
		}
	}

	[System.Serializable]
	public class BoolReference : DataReference<bool, BoolVariable> { }
}