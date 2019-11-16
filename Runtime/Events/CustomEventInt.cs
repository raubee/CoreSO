using System.Collections.Generic;

using UnityEngine;

namespace CINEVR.Core.Events
{
	[CreateAssetMenu(menuName= "CINEVR/Events/CustomEventInt")]
	public class CustomEventInt : ScriptableObject
	{
		private List<CustomEventListenerInt> listeners = new List<CustomEventListenerInt>();

		public void Raise(int data)
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
				listeners[i].OnEventRaised(data);
		}

		public void RegisterEvent(CustomEventListenerInt listener)
		{
			listeners.Add(listener);
		}

		public void UnRegisterEvent(CustomEventListenerInt listener)
		{
			listeners.Remove(listener);
		}
	}
}
