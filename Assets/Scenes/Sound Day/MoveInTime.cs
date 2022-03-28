using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInTime : MonoBehaviour
{
    //the time in seconds that the object will take to move
    public float MovementTime = 1.0f;
    //the Target that we will move towards
    public GameObject Target;

    //the location that the object will move to
    Vector3 TargetLocation;
    Vector3 StartingPosition;
    float totalTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //initialized totalTime to 0
        totalTime = 0f;
        //Set StartingPosition to the Transform's current position
        StartingPosition = transform.position;
        //Set TargetLocation to the Target's position
        TargetLocation = Target.transform.position;

    }

    void Update()
    {
        totalTime += Time.deltaTime; //add the time since the last frame
        if (totalTime >= MovementTime) totalTime = MovementTime;
        UpdateTargetLocation();
        //totalTime = Mathf.Clamp01(totalTime / MovementTime);
        transform.position = Vector3.Lerp(StartingPosition, TargetLocation, totalTime / MovementTime);
    }

    void UpdateTargetLocation()
    {
        TargetLocation = Target.transform.position;
    }
}
