using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pineapple : MonoBehaviour
{

    public Vector3 rotation = new Vector3(0, 1, 0);
    public Vector3 translation = new Vector3(0, 0, -1);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(rotation);
        transform.Translate(translation);
        //transform.Scale(1,1,1);
    }
}
