using UnityEngine;

namespace Data.Variables
{
    [CreateAssetMenu(fileName ="New Float Variable",menuName ="Variables/Base/Float")]
	[System.Serializable]
    public class FloatVariable : DataTypeBase<float>
    {
        public void ApplyChange(float amount)
        {
            Value += amount;
        }
	}

	[System.Serializable]
	public class FloatReference : DataReference<float,FloatVariable>{ }
}