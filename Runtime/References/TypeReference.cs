using AdLucem.CoreSO.Types;

namespace AdLucem.CoreSO.References
{
	public abstract class TypeReference<T, T1> where T1 : TypeVariable<T>
	{
		public bool UseConstant = true;
		public T ConstantValue;

		public T1 Variable;

		public T Value
		{
			get
			{
				return UseConstant ? ConstantValue : Variable.Value;
			}

			set
			{
				if (UseConstant)
					return;

				Variable.Value = value;
			}
		}
	}
}
