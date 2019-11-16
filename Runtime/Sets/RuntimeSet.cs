using System.Collections.Generic;

using UnityEngine;

namespace AdLucem.CoreSO.Sets
{
	public class RuntimeSet<T> : ScriptableObject
	{
		public List<T> Items = new List<T>();

		public void Add(T thing)
		{
			if (!Items.Contains(thing))
				Items.Add(thing);
		}

		public void Remove(T thing)
		{
			if (Items.Contains(thing))
				Items.Remove(thing);
		}
	}
}

