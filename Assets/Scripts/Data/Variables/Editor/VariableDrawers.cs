// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEditor;
using UnityEngine;

namespace Data.Variables
{

	public abstract class VariableDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			label = EditorGUI.BeginProperty(position, label, property);
			position = EditorGUI.PrefixLabel(position, label);

			EditorGUI.BeginChangeCheck();

			// Get properties
			SerializedProperty value = property.FindPropertyRelative("baseValue");

			
			// Store old indent level and set it to 0, the PrefixLabel takes care of it
			int indent = EditorGUI.indentLevel;
			EditorGUI.indentLevel = 0;
			
			EditorGUI.PropertyField(position,
				value,
				GUIContent.none);

			position.x += position.width / 2;

			/*EditorGUI.PropertyField(position,
				property.GetEndProperty(),
				GUIContent.none);*/

			if (EditorGUI.EndChangeCheck())
				property.serializedObject.ApplyModifiedProperties();

			EditorGUI.indentLevel = indent;
			EditorGUI.EndProperty();
		}
	}

	/*[CustomPropertyDrawer(typeof(FloatVariable))]
	public class FloatVariableDrawer : ReferenceDrawer { }

	[CustomPropertyDrawer(typeof(DataReference<int>))]
	public class IntReferenceDrawer : ReferenceDrawer { }

	[CustomPropertyDrawer(typeof(DataReference<bool>))]
	public class BoolReferenceDrawer : ReferenceDrawer { }
	*/
	/*[CustomPropertyDrawer(typeof(StringVariable))]
	public class StringVariableDrawer : VariableDrawer { }*/
}