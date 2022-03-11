using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    public float SteppingSize = 1f;
    public Vector3 _startPosition;
    public Color checkpointColor;

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

        if (volume.gameObject.CompareTag("Checkpoint"))
        {
            _startPosition = volume.transform.position;

            //1. get the volume by name
            //2. reference its Game Object that is attached to the collision
            //3. Use GetComponent<>() to access the Lightswitch script
            //4. use the Lightswitch script's myLight variable to change the light color


            volume.gameObject.GetComponent<Lightswitch>().myLight.color = checkpointColor;

            //This is using a function from the Lightswitch script.
            //Look at my version and you'll see a function that takes a Color as a parameter
            volume.gameObject.GetComponent<Lightswitch>().ChangeLightColor(Random.ColorHSV());
        }
    }
}
