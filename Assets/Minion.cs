using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minion : MonoBehaviour
{
    [Header("Minion Type Variables")]
    public int speed = 5;
    public int size = 5;
    public MinionType type = null; //part 1

    //private int currentHealth = -1;

    private void Start()
    {
        //currentHealth = maxHealth;
        //UpdateUI(currentHealth, maxHealth);
    }

    private void Update()
    {
        transform.localScale = new Vector3(size, size, 1);
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }

    //private void OnHitMinion(Minion minion)
    //{
    //    Destroy(minion.gameObject);
    //}

    //void UpdateUI(int a, int b)
    //{
    //    GetComponentInChildren<Text>().text = $"{a}/{b}";
    //}

    //void UpdateSpriteColor(Color color)
    //{
    //    GetComponent<SpriteRenderer>().color = color;
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Minion hit = collision.GetComponent<Minion>();
    //    if(hit != null)
    //    {
    //        OnHitMinion(hit);
    //    }
    //}
}