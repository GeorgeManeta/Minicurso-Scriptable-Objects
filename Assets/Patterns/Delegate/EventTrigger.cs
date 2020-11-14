using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    [SerializeField] EventBase eventToTrigger = null;

    private void Start()
    {
        TriggerEvent();
    }

    [ContextMenu("TriggerEvent")]
    void TriggerEvent()
    {
        if (eventToTrigger)
        {
            eventToTrigger.Trigger();
        }
    }
}
