using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMove : MonoBehaviour
{
    public float moveSpeed; //Create values to allow for the player to move round the field
    public float turnSpeed;


    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 8f; //Set speeds to 8 and 0.8
        turnSpeed = 0.8f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime); //Rotational movement 
        transform.Translate(-moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime); //Movement round the pitch as the player presses the iput keys
    }
}
