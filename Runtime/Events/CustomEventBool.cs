using System.Collections.Generic;

using UnityEngine;

namespace AdLucem.CoreSO.Events
{
	[CreateAssetMenu(menuName="CINEVR/Events/CustomEventBool")]
	public class CustomEventBool : ScriptableObject
	{
		private List<CustomEventListenerBool> listeners = new List<CustomEventListenerBool>();

		public void Raise(bool data)
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
				listeners[i].OnEventRaised(data);
		}

		public void RegisterEvent(CustomEventListenerBool listener)
		{
			listeners.Add(listener);
		}

		public void UnRegisterEvent(CustomEventListenerBool listener)
		{
			listeners.Remove(listener);
		}
	}
}
