using System.Collections.Generic;

using UnityEngine;

namespace CINEVR.Core.Events
{
	[CreateAssetMenu(menuName= "CINEVR/Events/CustomEventString")]
	public class CustomEventString : ScriptableObject
	{
		private List<CustomEventListenerString> listeners = new List<CustomEventListenerString>();

		public void Raise(string data)
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
				listeners[i].OnEventRaised(data);
		}

		public void RegisterEvent(CustomEventListenerString listener)
		{
			listeners.Add(listener);
		}

		public void UnRegisterEvent(CustomEventListenerString listener)
		{
			listeners.Remove(listener);
		}
	}
}
