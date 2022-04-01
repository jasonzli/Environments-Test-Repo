using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastToPlace : MonoBehaviour
{
    public GameObject ObjectToPlace;
    public Camera ViewCamera;


    void Update()
    {
        Ray ray = ViewCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            ObjectToPlace.transform.position = hitInfo.point;
            ObjectToPlace.transform.localRotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
            if (Input.GetMouseButtonDown(0))
            {
                PlaceObject(hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
        }


    }

    void PlaceObject(Vector3 position, Quaternion orientation)
    {
        Instantiate(ObjectToPlace, position, orientation);
    }
}
