﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomPropertyDrawer(typeof(ForceField.FFPerpendicularField))]
public class FFPerpendicularFieldDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUILayout.Space(-15f);
        EditorGUI.BeginProperty(position, label, property);
        if (FFEditorToolKit.DrawHeader(label.text))
        {
            FFEditorToolKit.BeginContents();

            EditorGUILayout.PropertyField(property.FindPropertyRelative("force"));
            EditorGUILayout.PropertyField(property.FindPropertyRelative("referencePoint"));

            SerializedProperty direction = property.FindPropertyRelative("_direction");
            FFEditorToolKit.DrawNormalizedVector(direction, "Direction");

            EditorGUILayout.PropertyField(property.FindPropertyRelative("distanceModifier"));

            FFEditorToolKit.EndContents();
        }
        EditorGUI.EndProperty();
    }
}
