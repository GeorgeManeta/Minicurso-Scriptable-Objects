using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace demo1 
{ 
    public class ScriptObjExample : MonoBehaviour
    {
        public ScriptObj reference;

        void Start()
        {
            Debug.Log("Creating instance of ScriptObj");
            ScriptObj newInstance = (ScriptObj) ScriptableObject.CreateInstance(typeof(ScriptObj));
        }
    }
}
