using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    public float SteppingSize = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * SteppingSize);
        }
        //Make it go backwards
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * SteppingSize);
        }
    }


    // void OnCollisionEnter(Collision collision)
    // {
    //     print($"Collision with {collision.gameObject.name}");
    //     if (collision.gameObject.CompareTag("Car"))
    //     {
    //         // Destroy(gameObject);
    //     }
    // }

    void OnTriggerEnter(Collider volume)
    {
        print($"Collision with {volume.gameObject.name}");
    }
}
