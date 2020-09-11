using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabsToSpawn = new List<GameObject>();
    [SerializeField] List<MinionType> typesToSpawn = new List<MinionType>();
    [SerializeField] int amount = 10;

    void Start()
    {
        SpawnMinions();
    }

    [ContextMenu("SpawnMinions")]
    public void SpawnMinions()
    {
        // there are prefabs to spawn
        if (prefabsToSpawn.Count > 0)
        {
            for(int i = 0; i < amount; i++)
            {
                // spawn random prefab from the list
                GameObject prefab = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Count)];
                GameObject minion = Instantiate(prefab, RandomPosition, Quaternion.identity, null);

                // if there are types to assign
                //if (typesToSpawn.Count > 0)
                //{
                //    // assign random type from the list
                //    MinionType type = typesToSpawn[Random.Range(0, typesToSpawn.Count)];
                //    minion.GetComponent<Minion>().type = type;
                //}
            }
        }
    }

    Vector2 RandomPosition 
    { 
        get
        {
            float x = 9;
            float y = 4.5f;
            x = Random.Range(-x, x);
            y = Random.Range(-y, y);
            return new Vector2(x, y);
        }
    }
}
