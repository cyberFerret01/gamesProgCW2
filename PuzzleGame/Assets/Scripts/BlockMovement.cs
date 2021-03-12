using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
       

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
        bool jumDown = Input.GetButtonDown("Jump");
        bool jumHeld = Input.GetButton("Jump");
        bool jumUp = Input.GetButtonUp("Jump");
        


        float movementTime = Time.deltaTime * 4;

       




        if (horDown && Input.GetAxisRaw("Horizontal") > 0)
        {
            //transform.rotation = Quaternion.Euler(0, 90, 0);
            //transform.Rotate(0, 180, 0, Space.World);
            transform.Translate(Vector3.forward * movementTime);
           

        }
        if (horHeld && Input.GetAxisRaw("Horizontal") > 0)
        {
           
            transform.Translate(Vector3.forward * movementTime);
           

        }
        if (horDown && Input.GetAxisRaw("Horizontal") < 0)
        {
           
            // transform.Rotate(0, 0, 0, Space.World);
            transform.Translate(Vector3.back * movementTime);
            

        }
        if (horHeld && Input.GetAxisRaw("Horizontal") < 0)
        {
           
            transform.Translate(Vector3.back * movementTime);
           

        }

        if (horUp)
        {
           
        }

        if (verDown && Input.GetAxisRaw("Vertical") < 0)
        {
           
            //transform.Rotate(0, 90, 0, Space.World);
            transform.Translate(Vector3.right * movementTime);
            

        }
        if (verHeld && Input.GetAxisRaw("Vertical") < 0)
        {
           
            transform.Translate(Vector3.right * movementTime);
            

        }
        if (verDown && Input.GetAxisRaw("Vertical") > 0)
        {
            
            //   transform.Rotate(0, -90, 0, Space.World);
            transform.Translate(Vector3.left * movementTime);
            

        }
        if (verHeld && Input.GetAxisRaw("Vertical") > 0)
        {
           
            transform.Translate(Vector3.left * movementTime);
            

        }
        if (verUp)
        {
            

        }




    }
}
