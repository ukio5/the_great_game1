using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_coin : MonoBehaviour
{
    public GameObject player;
    AudioSource sound;
    Rigidbody2D playerRb;
    Collider2D playerColl;
    int score = 0;
    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
        playerColl = player.GetComponent<Collider2D>();
        sound = player.GetComponent<AudioSource>();
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            sound.Play();
            score++;
            Debug.Log(score);
            Destroy(collision.gameObject);
        }
    }
}
