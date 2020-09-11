using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitCollider : MonoBehaviour
{
    [SerializeField] Vector2 distance = default;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        Vector2 pos = go.transform.position;
        pos += distance;
        go.transform.position = pos;
    }
}
