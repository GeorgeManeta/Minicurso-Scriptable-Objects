using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Subject : ScriptableObject
{
    private List<Observer> observers = new List<Observer>();

    public void Trigger() {
        for (int i = observers.Count - 1; i >= 0; i--)
            observers[i].Trigger();
    }

    public void Register(Observer observer) {
        if (observers.Contains(observer) == false){
            observers.Add(observer);
        }
    }

    public void Unregister(Observer observer) {
        observers.Remove(observer);
    }
}
