using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Variables
{
	[System.Serializable]
	public abstract class DataReference<T,U> where U : DataTypeBase<T>
	{
		public bool UseConstant = true;
		public T ConstantValue;
		public U Variable;

		public DataReference()
		{ }

		public DataReference(T value)
		{
			UseConstant = true;
			ConstantValue = value;
		}

		public T Value
		{
			get { return UseConstant ? ConstantValue : Variable.Value; }
			set { Variable.Value = value; }
		}

		public void SetVariable(U var){
			Variable = var;
		}

		public static implicit operator T(DataReference<T,U> reference)
		{
			return reference.Value;
		}
	}
}
