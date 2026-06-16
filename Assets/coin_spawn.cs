using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_spawn : MonoBehaviour
{
    public GameObject[] coins;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(spawn), 3f, 3.5f);
    }
    void Update()
    {
        
    }
    void spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f);
        GameObject t_coin = Instantiate(coins[Random.Range(0, coins.Length)], pos, Quaternion.identity);
        Destroy(t_coin, 5f);
    }
}
