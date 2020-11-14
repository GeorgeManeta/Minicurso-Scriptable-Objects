using UnityEngine;
using UnityEngine.Events;

public class UnityEventObserver : Observer
{
    [Tooltip("Unity events that this observer will trigger when any of them subjects is triggered.")]
    [SerializeField]
    private UnityEvent unityEvent = new UnityEvent();

    public override void Trigger()
    {
        unityEvent.Invoke();
    }
}
