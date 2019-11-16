using UnityEngine;
using UnityEditor;
using CINEVR.Core.Events;

namespace CINEVR.Core.Editor
{
	[CustomEditor(typeof(CustomEvent))]
	public class CustomEventEditor : UnityEditor.Editor
	{
		CustomEvent customEvent;
		public void OnEnable()
		{
			customEvent = target as CustomEvent;
		}

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			EditorGUILayout.Space();

			if(GUILayout.Button("Raise"))
			{
				customEvent.Raise();
			}
		}
	}
}

