using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb;
    float speed = 2f;
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            rb.transform.position += Vector3.up * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftControl))
            {
                rb.transform.position += Vector3.up * (speed) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position += Vector3.left * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftControl))
            {
                rb.transform.position += Vector3.left * (speed * 2) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.position += Vector3.down * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftControl))
            {
                rb.transform.position += Vector3.down * (speed) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.position += Vector3.right * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftControl))
            {
                rb.transform.position += Vector3.right * (speed * 2) * Time.deltaTime;
            }
        }
    }
}
