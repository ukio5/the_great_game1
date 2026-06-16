using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_move : MonoBehaviour
{
    public GameObject coin;
    Rigidbody2D rb;
    Vector3 pos;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0);
    }
    void Update()
    {
        rb.transform.position = Vector3.MoveTowards(rb.transform.position, pos, 2f * Time.deltaTime);
        if (Vector3.Distance(rb.transform.position, pos) < 0.1f)
        {
            ChooseNewPoint();
        }
    }
    void ChooseNewPoint()
    {
        pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0);
    }
}
