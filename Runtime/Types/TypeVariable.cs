using UnityEngine;

namespace AdLucem.CoreSO.Types
{
	public abstract class TypeVariable<T> : ScriptableObject
	{
		public T Value;
	}
}
