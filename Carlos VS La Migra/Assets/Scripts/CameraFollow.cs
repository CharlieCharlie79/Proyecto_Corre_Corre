using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float cameraDistance = 30.0f;
    public Vector2 minimumBoundary;
    public Vector2 maximumBoundary;
    void Awake()
    {
        //fix the camera distance
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }


    void FixedUpdate()
    {
        //Follows Player
        transform.position = new Vector3(Target.position.x, Target.position.y, transform.position.z);



        //Bounderies
        ////////
        transform.position = new Vector3
        (
        Mathf.Clamp(transform.position.x, minimumBoundary.x, maximumBoundary.x),
        Mathf.Clamp(transform.position.y, minimumBoundary.y, maximumBoundary.y),
        transform.position.z
        );
        ///////
    }   
  

}
