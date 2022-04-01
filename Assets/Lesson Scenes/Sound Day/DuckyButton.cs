using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))] //adds an audio source component to the object *with* the script
public class DuckyButton : MonoBehaviour
{
    [Tooltip("The audio clip to play when the button is pressed")]
    public AudioSource DuckSound; //the annoying duck sound

    void Awake()
    {
        DuckSound = GetComponent<AudioSource>(); //this gets the game object's audio source and sets it
    }

    void OnMouseDown()
    {
        if (DuckSound.isPlaying)
        {
            return; //exit if we are playing
        }
        DuckSound.Play();
    }
}
