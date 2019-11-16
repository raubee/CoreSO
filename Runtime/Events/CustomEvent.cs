using System.Collections.Generic;

using UnityEngine;

namespace CINEVR.Core.Events
{
	[CreateAssetMenu(menuName="CINEVR/Events/CustomEvent")]
	public class CustomEvent : ScriptableObject
	{
		private List<CustomEventListener> listeners = new List<CustomEventListener>();

		public void Raise()
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
				listeners[i].OnEventRaised();
		}

		public void RegisterEvent(CustomEventListener listener)
		{
			listeners.Add(listener);
		}

		public void UnRegisterEvent(CustomEventListener listener)
		{
			listeners.Remove(listener);
		}
	}
}
