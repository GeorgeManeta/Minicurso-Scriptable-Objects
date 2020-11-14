using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Delegate/Dialogue")]
public class Dialogue : EventBase
{
    [TextArea]
    [SerializeField] List<string> lines = new List<string>();
    public override void Trigger()
    {
        foreach(string line in lines)
        {
            Debug.Log(line);
        }
    }
}
