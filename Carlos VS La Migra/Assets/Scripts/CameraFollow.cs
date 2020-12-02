using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float cameraDistance = 30.0f;
   
    void Awake()
    {
        //fix the camera distance
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }


    void FixedUpdate()
    {
        //Follows Player
        transform.position = new Vector3(Target.position.x, Target.position.y, transform.position.z);
    }



}
