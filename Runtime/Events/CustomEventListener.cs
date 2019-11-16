using UnityEngine;
using UnityEngine.Events;

namespace CINEVR.Core.Events
{
	public class CustomEventListener : MonoBehaviour
	{
		public CustomEvent Event;
		public UnityEvent Response;

		public void OnEventRaised()
		{
			Response?.Invoke();
		}

		public void OnEnable()
		{
			Event?.RegisterEvent(this);
		}

		public void OnDisable()
		{
			Event?.UnRegisterEvent(this);
		}
	}
}
