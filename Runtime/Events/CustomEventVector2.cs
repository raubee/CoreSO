using System.Collections.Generic;

using UnityEngine;

namespace AdLucem.CoreSO.Events
{
	[CreateAssetMenu(menuName= "CINEVR/Events/CustomEventVector2")]
	public class CustomEventVector2 : ScriptableObject
	{
		private List<CustomEventListenerVector2> listeners = new List<CustomEventListenerVector2>();

		public void Raise(Vector2 data)
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
				listeners[i].OnEventRaised(data);
		}

		public void RegisterEvent(CustomEventListenerVector2 listener)
		{
			listeners.Add(listener);
		}

		public void UnRegisterEvent(CustomEventListenerVector2 listener)
		{
			listeners.Remove(listener);
		}
	}
}
