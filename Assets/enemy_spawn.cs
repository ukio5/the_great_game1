using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class enemy_spawn : MonoBehaviour
{
    public GameObject[] enemys;
    void Start()
    {
        InvokeRepeating(nameof(spawn), 3f, 1f);
    }
    void Update()
    {
        
    }
    void spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f);
        GameObject enemy = Instantiate(enemys[Random.Range(0, enemys.Length)], pos, Quaternion.identity);
        Destroy(enemy, 10f);
    }
}
