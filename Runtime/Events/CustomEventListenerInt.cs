using System;

using UnityEngine;
using UnityEngine.Events;

namespace CINEVR.Core.Events
{
	public class CustomEventListenerInt : MonoBehaviour
	{
		public CustomEventInt Event;

		[Serializable]
		public class IntEvent : UnityEvent<int> { }
		public IntEvent Response;

		public void OnEventRaised(int data)
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
