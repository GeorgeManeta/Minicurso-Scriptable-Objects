using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    [SerializeField] EventBase eventToTrigger = null;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
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
