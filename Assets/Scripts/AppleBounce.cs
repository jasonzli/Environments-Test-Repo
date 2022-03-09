using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleBounce : MonoBehaviour
{
    //Public fields show up in the Unity Editor for us to manipulate and change
    public float height;
    public float speed;
    public float offset;
    
    // Start is called before the first frame update
    void Start()
    {
        //I can use transform.Translate
        //Vector3 direction = new Vector3(0,1,0);
        //transform.Translate(direction);//where direction is a Vector3

        //Other way, is to directly set the value
        //transform.position = direction;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x, 
            // our new height = height * sin( speed * x + offset)
            height * Mathf.Sin ( speed * Time.frameCount + offset ),
            transform.position.z);
        transform.position = newPosition;
    }

}
