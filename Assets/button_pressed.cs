using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_pressed : MonoBehaviour
{
    public AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    void Update()
    {
        
    }
    public void PlaySound()
    {
        sound.Play();
        Wait();
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
