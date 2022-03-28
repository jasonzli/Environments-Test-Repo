using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    AudioSource myAudioSource; //declare the audio source so we can play it later
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>(); //set the audio source to the component on the object
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myAudioSource.Play(); //play when we enter
            transform.Rotate(0, 90, 0);
        }
    }

}
