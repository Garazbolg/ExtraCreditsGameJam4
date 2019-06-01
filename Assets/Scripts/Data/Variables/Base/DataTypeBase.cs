using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Variables
{
	[System.Serializable]
	public abstract class DataTypeBase<T> : DataBase
	{
		private T value;

		public T Value{
			get {
				return value;
			}
			set{ this.value = value; }
		}
		
		public void SetValue(DataTypeBase<T> value)
		{
			Value = value.Value;
		}

		public static implicit operator T(DataTypeBase<T> reference)
		{
			return reference.Value;
		}
	}

}