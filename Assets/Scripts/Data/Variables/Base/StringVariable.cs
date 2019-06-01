using UnityEngine;

namespace Data.Variables
{
    [CreateAssetMenu]
    public class StringVariable : DataTypeBase<string>
    {
    }

	[System.Serializable]
	public class StringReference : DataReference<string,StringVariable>{ }
}