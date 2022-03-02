using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(MoverObj))]

public class MoverEditor : Editor
{
    public override void OnInspectorGUI() 
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Click 1"))
        {
            var castedTarget = target as MoverObj;
            castedTarget.Move();
            Debug.Log("Click 2");
        }
    }
}
