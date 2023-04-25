using UnityEditor;
using UnityEngine;

namespace Nop.ReadOnlyInspector
{
	[CustomPropertyDrawer(typeof(ReadOnlyInspectorAttribute))]
	public class ReadOnlyInspectorPropertyDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			// disable editing
			GUI.enabled = false;
			label.text += " [RO]";
			label.tooltip += " (Read Only)";
			EditorGUILayout.PropertyField(property, label);
			GUI.enabled = true;
		}
	}
}
