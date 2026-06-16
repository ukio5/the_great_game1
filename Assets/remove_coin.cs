using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_coin : MonoBehaviour
{
    public GameObject enemy;
    Rigidbody2D enemyRb;
    Collider2D enemyColl;
    void Start()
    {
        enemyRb = enemy.GetComponent<Rigidbody2D>();
        enemyColl = enemy.GetComponent<Collider2D>();
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
        }
    }
}
