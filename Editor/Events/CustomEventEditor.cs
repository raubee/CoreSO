using UnityEngine;
using UnityEditor;
using AdLucem.CoreSO.Events;

namespace AdLucem.CoreSO.Editor
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

