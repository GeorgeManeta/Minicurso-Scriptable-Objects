using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace demo1
{
    [CreateAssetMenu(menuName = "SampleScriptableObject")]
    public class SampleScriptableObject : ScriptableObject
    {
        [SerializeField] float importantValue;

        public void Awake()
        {
            Debug.Log($"Awake {name}");
        }

        public void OnEnable()
        {
            Debug.Log($"OnEnable {name}");
        }

        public void OnDisable()
        {
            Debug.Log($"OnDisable {name}");
        }

        public void OnDestroy()
        {
            Debug.Log($"OnDestroy {name}");
        }
    }
}