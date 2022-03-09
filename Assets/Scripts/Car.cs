using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float Speed = 5f;

    private Vector3 _startingPosition;


    void Start()
    {
        //Store the starting position at the beginning
        _startingPosition = transform.position;
    }

    void Update()
    {
        //Time.deltaTime converts values into units per second
        //So we can use Speed to determine how fast the car moves in units per second
        //while using the Vector3.left to choose the direction of the car
        transform.Translate(Vector3.left * Speed * Time.deltaTime);

    }

    //This requires that there is a rigidbody and collider component
    //The collider *must* be a trigger
    private void OnTriggerEnter(Collider other)
    {
        //reset position if we collide with the wall
        if (other.gameObject.name == "Wall" ||
            other.gameObject.CompareTag("Wall"))
        {
            transform.position = _startingPosition;
        }
    }


}












// public Vector2 SpeedMinMax = new Vector2(.1f, 2f);
// private Vector3 _startPosition;
// private float _speed;

// // Start is called before the first frame update
// void Start()
// {
//     Setup();
// }

// void Setup()
// {
//     _startPosition = transform.position;
//     _speed = Random.Range(SpeedMinMax.x, SpeedMinMax.y);
// }

// // Update is called once per frame
// void Update()
// {
//     transform.Translate(Vector3.left * _speed * Time.deltaTime);
// }

// void OnCollisionEnter(Collision collision)
// {
//     if (collision.gameObject.CompareTag("Wall"))
//     {
//         transform.position = _startPosition;
//     }
// }

