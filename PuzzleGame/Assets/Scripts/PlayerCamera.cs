using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCamera : MonoBehaviour
{

    public GameObject objectToFollow;
    public float xrotation = 1.0F;
    public float speed = 2.0F;
    public float ydist = 4.0F;
    private Vector3 rotateValue;
    public bool isInverted;

    void Start()
    {
        isInverted = objectToFollow.GetComponent<GravityBlock>().getIsInverted();
    }

    void Update()
    {
        isInverted = objectToFollow.GetComponent<GravityBlock>().getIsInverted();
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.z = objectToFollow.transform.position.z;
        position.y = objectToFollow.transform.position.y + ydist;
        position.x = objectToFollow.transform.position.x + 9;

        this.transform.position = position;

        Debug.Log(isInverted);

        if (isInverted == true)
        {
            rotateValue = new Vector3(-30, -90, 0);
            transform.eulerAngles = rotateValue;
            ydist = -4.0F;
        }
        else if (isInverted == false)
        {
            rotateValue = new Vector3(30, -90, 0);
            transform.eulerAngles = rotateValue;
            ydist = 4.0F;
        }
        
    }

    public void Switch(GameObject player)
    {
        Debug.Log("Switch");
        objectToFollow = player;
    }

}