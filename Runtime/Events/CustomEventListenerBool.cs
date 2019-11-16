using System;

using UnityEngine;
using UnityEngine.Events;

namespace CINEVR.Core.Events
{
	public class CustomEventListenerBool : MonoBehaviour
	{
		public CustomEventBool Event;

		[Serializable]
		public class BoolEvent : UnityEvent<bool> { }
		public BoolEvent Response;

		public void OnEventRaised(bool data)
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
