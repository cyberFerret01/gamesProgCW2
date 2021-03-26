using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    GameObject target;
    public float smoothSpeed = 32f;
    public Vector3 offset;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
      
    }

  public  void LateUpdate()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

    
