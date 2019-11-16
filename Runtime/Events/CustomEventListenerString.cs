using System;

using UnityEngine;
using UnityEngine.Events;

namespace AdLucem.CoreSO.Events
{
	public class CustomEventListenerString : MonoBehaviour
	{
		public CustomEventString Event;

		[Serializable]
		public class StringEvent : UnityEvent<string> { }
		public StringEvent Response;

		public void OnEventRaised(string data)
		{
			Response.Invoke(data);
		}

		public void OnEnable()
		{
			if (Event != null)
			{
				Event.RegisterEvent(this);
			}
		}

		public void OnDisable()
		{
			if (Event != null)
			{
				Event.UnRegisterEvent(this);
			}
		}
	}
}
