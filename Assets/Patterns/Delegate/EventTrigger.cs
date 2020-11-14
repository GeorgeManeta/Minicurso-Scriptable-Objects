using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    [SerializeField] EventBase eventToTrigger = null;
    [SerializeField] KeyCode triggerKey = KeyCode.None;

    private void Update()
    {
        if(Input.GetKeyDown(triggerKey))
        {
            TriggerEvent();
        }
    }

    void TriggerEvent()
    {
        if (eventToTrigger)
        {
            eventToTrigger.Trigger();
        }
    }
}
