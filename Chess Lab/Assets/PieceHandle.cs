using UnityEngine;
using UnityEditor;
public class PieceHandle : MonoBehaviour
{
    public float value = 7.0f;
}

// A tiny custom editor for ExampleScript component
[CustomEditor(typeof(PieceHandle))]
public class ExampleEditor : Editor
{
    // Custom in-scene UI for when ExampleScript
    // component is selected.
    public void OnSceneGUI()
    {
        var t = target as PieceHandle;
        var tr = t.transform;
        var pos = tr.position;
        // display an orange disc where the object is
        var color = new Color(0.4438857f, 0.990566f, 0.7032948f, 1);
        Handles.color = color;
        Handles.DrawWireDisc(pos, -tr.forward, .5f);
        // display object "value" in scene
        GUI.color = color;
        //Handles.Label(pos, t.value.ToString("F1"));
    }
}
