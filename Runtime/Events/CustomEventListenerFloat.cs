using System;

using UnityEngine;
using UnityEngine.Events;

namespace CINEVR.Core.Events
{
	public class CustomEventListenerFloat : MonoBehaviour
	{
		public CustomEventFloat Event;

		[Serializable]
		public class FloatEvent : UnityEvent<float> { }
		public FloatEvent Response;

		public void OnEventRaised(float data)
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
