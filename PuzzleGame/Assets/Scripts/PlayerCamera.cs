using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCamera : MonoBehaviour
{

    public GameObject objectToFollow;
    public float xrotation = 1.0F;
    public float speed = 2.0F;
    public float rotateSize = 60.0F;
    private Vector3 rotateValue;

    void Update()
    {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.z = objectToFollow.transform.position.z;
        position.y = objectToFollow.transform.position.y + 4;
        position.x = objectToFollow.transform.position.x + 9;

        transform.eulerAngles = transform.eulerAngles + rotateValue;
        this.transform.position = position;
    }

    public void InvertCameraDown() 
    { 
        //xrotation = (xrotation * -1.0F);
        rotateValue = new Vector3(0, rotateSize * -1, 0);
    }

}