using UnityEngine;
using System.Collections.Generic;

public abstract class Observer : MonoBehaviour
{
    [Tooltip("Subjects that this observer will listen to.")]
    [SerializeField]
    private List<Subject> subjects = new List<Subject>();

    public abstract void Trigger();
    
    private void OnEnable() {
        foreach(Subject s in subjects) {
            s.Register(this);//
        }
    }

    private void OnDisable() {
        foreach (Subject s in subjects) {
            s.Unregister(this);
        }
    }

}
