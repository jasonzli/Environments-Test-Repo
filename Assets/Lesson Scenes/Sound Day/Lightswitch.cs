using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        //Start with the light off
        //myLight.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //The code to turn something on and off when a player collides
        if (other.gameObject.CompareTag("Player") ||
            other.gameObject.name == "Player")
        {
            //FlipLightSwitch(); //flip the switch
            //We turned this off because we wanted to change the color
        }
    }

    //A function that takes a Color parameter and updates the myLight color
    public void ChangeLightColor(Color color)
    {
        myLight.color = color;
    }

    //A function to turn the light on and off
    void FlipLightSwitch()
    {
        //Boolean switch for the enabled, note the ! operator
        myLight.enabled = !myLight.enabled;

        //You can also directly set intensity
        //myLight.intensity = myLight.intensity == 0 ? 1 : 0;
    }
}
