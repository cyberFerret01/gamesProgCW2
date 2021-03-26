using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class playerJump : MonoBehaviour
{
    Rigidbody rb;
        // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0f, 2000f, 0f));  //Jump up with a force of 2000 if spacebar is pressed
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.AddForce(new Vector3(-3000f, 0f, 0f)); //Dash forward by 3000 if q button is pressed
        }
        return;
    }
}
