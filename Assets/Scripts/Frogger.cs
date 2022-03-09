using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    public float SteppingSize = 1f;
    public Vector3 _startPosition;

    void Start()
    {
        _startPosition = transform.position;
    }
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


    //Trigger requires collider and rigidbody, and the collider must be a trigger
    void OnTriggerEnter(Collider volume)
    {
        print($"Collision with {volume.gameObject.name}");
        if (volume.gameObject.CompareTag("Car"))
        {
            transform.position = _startPosition;
        }
    }
}
