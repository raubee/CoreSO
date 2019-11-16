using System;

using UnityEngine;
using UnityEngine.Events;

namespace CINEVR.Core.Events
{
	public class CustomEventListenerVector2 : MonoBehaviour
	{
		public CustomEventVector2 Event;

		[Serializable]
		public class Vector2Event : UnityEvent<Vector2> { }
		public Vector2Event Response;

		public void OnEventRaised(Vector2 data)
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
