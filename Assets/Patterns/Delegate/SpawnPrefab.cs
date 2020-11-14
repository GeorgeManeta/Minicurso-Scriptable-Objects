using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Delegate/SpawnPrefab")]
public class SpawnPrefab : EventBase
{
    [SerializeField] GameObject prefab = null;

    public override void Trigger()
    {
        if (prefab)
        {
            Vector3 position = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 0);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
