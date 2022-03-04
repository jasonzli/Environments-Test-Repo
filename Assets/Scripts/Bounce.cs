using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float offset = 0f;

    public float amplitude = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, Mathf.Sin(Time.frameCount * .05f + offset), 0);
        transform.localPosition =
            new Vector3(transform.localPosition.x,
                        amplitude * Mathf.Sin(Time.frameCount * .05f + offset),
                        transform.localPosition.z);
    }
}
