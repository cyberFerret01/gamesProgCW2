using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    private float speedUp;
    // Start is called before the first frame update
    void Start()
    {
        speedUp = 1.0F;
    }


    // Update is called once per frame
    void Update()
    {

        bool horDown = Input.GetButtonDown("Horizontal");
        bool horHeld = Input.GetButton("Horizontal");
        bool horUp = Input.GetButtonUp("Horizontal");
        bool verDown = Input.GetButtonDown("Vertical");
        bool verHeld = Input.GetButton("Vertical");
        bool verUp = Input.GetButtonUp("Vertical");

        float movementTime = Time.deltaTime * 5 * speedUp;

        if (horDown && Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector3.forward * movementTime);
        }
        if (horHeld && Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector3.forward * movementTime);
        }
        if (horDown && Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector3.back * movementTime);
        }
        if (horHeld && Input.GetAxisRaw("Horizontal") < 0)
        { 
            transform.Translate(Vector3.back * movementTime);
        }

        if (verDown && Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector3.right * movementTime);
        }
        if (verHeld && Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector3.right * movementTime);
        }
        if (verDown && Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector3.left * movementTime);
        }
        if (verHeld && Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector3.left * movementTime);
        }

    }

    public void SpeedUp()
    {
        speedUp = 3.0F;
    }

    public void SlowDown()
    {
        speedUp = 1.0F;
    }
}
