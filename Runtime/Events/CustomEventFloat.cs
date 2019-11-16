using System.Collections.Generic;

using UnityEngine;

namespace CINEVR.Core.Events
{
	[CreateAssetMenu(menuName="CINEVR/Events/CustomEventFloat")]
	public class CustomEventFloat : ScriptableObject
	{
		private List<CustomEventListenerFloat> listeners = new List<CustomEventListenerFloat>();

		public void Raise(float data)
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
				listeners[i].OnEventRaised(data);
		}

		public void RegisterEvent(CustomEventListenerFloat listener)
		{
			listeners.Add(listener);
		}

		public void UnRegisterEvent(CustomEventListenerFloat listener)
		{
			listeners.Remove(listener);
		}
	}
}
