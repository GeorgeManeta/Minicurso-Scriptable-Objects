#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Subject))]
public class SubjectEditor : Editor
{
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        GUI.enabled = Application.isPlaying;

        Subject e = target as Subject;
        if (GUILayout.Button("Trigger"))
            e.Trigger();
    }
}
#endif