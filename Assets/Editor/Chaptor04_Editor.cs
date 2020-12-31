using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(Chapter04))]
[CanEditMultipleObjects]
public class Chaptor04_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        Chapter04 chapter = (Chapter04)target;

        if (GUILayout.Button(new GUIContent("Change Cube Color")))
        {
            if(chapter.gameObject.GetComponent<MeshRenderer>())
                chapter.gameObject.GetComponent<MeshRenderer>().sharedMaterial.color = Random.ColorHSV();
        }

        if (GUILayout.Button(new GUIContent("Change Background Color")))
        {
            if (chapter.gameObject.GetComponent<Camera>())
                chapter.gameObject.GetComponent<Camera>().backgroundColor = Random.ColorHSV();
        }

        chapter.size = EditorGUILayout.Slider("size", chapter.size, 0f, 10f);
        chapter.transform.localScale = new Vector3(chapter.size, chapter.size, chapter.size);

    }

    
}
