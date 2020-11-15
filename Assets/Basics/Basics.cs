using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace demo1
{
    public class Basics : MonoBehaviour
    {
        [SerializeField] SampleScriptableObject reference;

        [ContextMenu("CreateInstance")]
        void CreateInstance()
        {
            reference = (SampleScriptableObject) 
                ScriptableObject.CreateInstance(typeof(SampleScriptableObject));
        }

        [ContextMenu("CloneReference")]
        void CloneReference()
        {
            reference = Instantiate(reference);
        }

        [ContextMenu("SaveAsAsset")]
        void SaveAsAsset()
        {
            string path = "Assets/SavedAtRuntime.asset";
            AssetDatabase.CreateAsset(reference, path);
        }
    }
}

