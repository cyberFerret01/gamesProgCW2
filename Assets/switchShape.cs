using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchShape : MonoBehaviour
{
   public GameObject sphere;
   public GameObject cube;
   public GameObject cone;
   public GameObject prism;
   public Vector3 offset;
   public Vector3 offset2;
   public Transform Player;
   Vector3 originalPos;

    void Start()
    {
        cube.SetActive(true);
        sphere.SetActive(false);
        cone.SetActive(false);
        prism.SetActive(false);
        originalPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);

    }
    void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "SWC")
        {
            if (cube.active == true) //Cube->Sphere
            {
                sphere.transform.position = cube.transform.position;
                cube.SetActive(false);
                sphere.SetActive(true);
            }
            else if (cone.active == true) //Cone->Sphere
            {
                sphere.transform.position = cone.transform.position;
                cone.SetActive(false);
                sphere.SetActive(true);
            }

            else if (prism.active == true) //Prism->Sphere
            {
                sphere.transform.position = prism.transform.position;
                prism.SetActive(false);
                sphere.SetActive(true);
            }
                        
        }

        else if (Player.gameObject.tag == "SWS")
        {
            if (sphere.active == true) //Sphere->Cube
            {
                cube.transform.position = sphere.transform.position;
                sphere.SetActive(false);
                cube.SetActive(true);
            }
            else if (cone.active == true) //Cone->Cube
            {
                cube.transform.position = cone.transform.position;
                cone.SetActive(false);
                cube.SetActive(true);
            }

            else if (prism.active == true) //Prism->Cube
            {
                cube.transform.position = cube.transform.position;
                prism.SetActive(false);
                cube.SetActive(true);
            }

        }

        else if (Player.gameObject.tag == "SWCN")
        {
            if (sphere.active == true) //Sphere->Cone
            {
                cone.transform.position = sphere.transform.position;
                sphere.SetActive(false);
                cone.SetActive(true);
            }
            else if (cube.active == true) //Cube->Cone
            {
                cone.transform.position = cube.transform.position;
                cube.SetActive(false);
                cone.SetActive(true);
            }

            else if (prism.active == true) //Prism->Cone
            {
                cone.transform.position = prism.transform.position;
                prism.SetActive(false);
                cone.SetActive(true);
            }

        }

        else if (Player.gameObject.tag == "SWP")
        {
            if (sphere.active == true) //Sphere->Prism
            {
                prism.transform.position = sphere.transform.position;
                sphere.SetActive(false);
                prism.SetActive(true);
            }
            else if (cube.active == true) //Cube->Prism
            {
                prism.transform.position = cube.transform.position;
                cube.SetActive(false);
                prism.SetActive(true);
            }

            else if (cone.active == true) //Cone->Prism
            {
                prism.transform.position = cone.transform.position;
                cone.SetActive(false);
                prism.SetActive(true);
            }

        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (sphere.active == true) //Sphere->Cone
            {
                cone.transform.position = sphere.transform.position;
                sphere.SetActive(false);
                cone.SetActive(true);
            }
            else if (cube.active == true) //Cube->Sphere
            {
                sphere.transform.position = cube.transform.position;
                cube.SetActive(false);
                sphere.SetActive(true);
            }

            else if (cone.active == true) //Cone->Prism
            {
                prism.transform.position = cone.transform.position+offset;
                cone.SetActive(false);
                prism.SetActive(true);
            }

            else if (prism.active == true) //Prism -> Cube
            {
                cube.transform.position = prism.transform.position+offset2;
                prism.SetActive(false);
                cube.SetActive(true);
            }
        }
    }


}
