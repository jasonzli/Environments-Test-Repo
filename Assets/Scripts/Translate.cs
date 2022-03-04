using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 direction = new Vector3(0, 0, 1);
    public bool RandomSpeed = false;
    public bool UseNoiseVariation = false;
    public float NoiseSpeed = 1f;

    private float _variation = 0f;
    private float _noiseSeed;

    // Start is called before the first frame update
    void Start()
    {
        if (RandomSpeed)
        {
            speed = Random.Range(0.1f, 2f);
        }
        if (UseNoiseVariation)
        {
            _noiseSeed = System.DateTime.Now.Millisecond;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //modulate speed based on noise
        _variation = Mathf.PerlinNoise(Time.time * NoiseSpeed, _noiseSeed);
        //transform translation
        transform.Translate(direction * (speed + _variation));









        //reset position if it gets too far
        if (transform.position.z > 400)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);// Vector3.zero;
        }
    }
}
