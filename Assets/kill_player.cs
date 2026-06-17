using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class kill_player : MonoBehaviour
{
    public GameObject enemy;
    AudioSource sound;
    Rigidbody2D enemyRb;
    Collider2D enemyColl;
    void Start()
    {
        enemyRb = enemy.GetComponent<Rigidbody2D>();
        enemyColl = enemy.GetComponent<Collider2D>();
        sound = enemy.GetComponent<AudioSource>();

        Time.timeScale = 1f;
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sound.Play();
            Wait();
            SceneManager.LoadScene(0);
            Destroy(collision.gameObject);
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
    }
}
