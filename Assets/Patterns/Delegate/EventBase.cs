using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// doesn't need [CreateAssetMenu] 'cause is an abstract class
public abstract class EventBase : ScriptableObject
{
    public abstract void Trigger();
}
