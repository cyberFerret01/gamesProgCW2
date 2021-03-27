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
    public Transform thisObject;

    //Vector3 originalPos;
    public float pressRange = 0.5f;
    public LayerMask playerLayers;


    void Start()
    {
        cube.SetActive(true);
        sphere.SetActive(false);
        cone.SetActive(false);
        prism.SetActive(false);
        //originalPos = new Vector3(thisObject.transform.position.x, thisObject.transform.position.y, thisObject.transform.position.z);

    }
    void shapeCollider()
    {
        if (thisObject.gameObject.tag == "SWC")
        {
            if (cube.activeSelf == true) //Cube->Sphere
            {
                sphere.transform.position = cube.transform.position;
                cube.SetActive(false);
                sphere.SetActive(true);
            }
            else if (cone.activeSelf == true) //Cone->Sphere
            {
                sphere.transform.position = cone.transform.position;
                cone.SetActive(false);
                sphere.SetActive(true);
            }

            else if (prism.activeSelf == true) //Prism->Sphere
            {
                sphere.transform.position = prism.transform.position;
                prism.SetActive(false);
                sphere.SetActive(true);
            }

        }

        else if (thisObject.gameObject.tag == "SWS")
        {
            if (sphere.activeSelf == true) //Sphere->Cube
            {
                cube.transform.position = sphere.transform.position;
                sphere.SetActive(false);
                cube.SetActive(true);
            }
            else if (cone.activeSelf == true) //Cone->Cube
            {
                cube.transform.position = cone.transform.position;
                cone.SetActive(false);
                cube.SetActive(true);
            }

            else if (prism.activeSelf == true) //Prism->Cube
            {
                cube.transform.position = cube.transform.position;
                prism.SetActive(false);
                cube.SetActive(true);
            }

        }

        else if (thisObject.gameObject.tag == "SWCN")
        {
            if (sphere.activeSelf == true) //Sphere->Cone
            {
                cone.transform.position = sphere.transform.position;
                sphere.SetActive(false);
                cone.SetActive(true);
            }
            else if (cube.activeSelf == true) //Cube->Cone
            {
                cone.transform.position = cube.transform.position;
                cube.SetActive(false);
                cone.SetActive(true);
            }

            else if (prism.activeSelf == true) //Prism->Cone
            {
                cone.transform.position = prism.transform.position;
                prism.SetActive(false);
                cone.SetActive(true);
            }

        }

        else if (thisObject.gameObject.tag == "SWP")
        {
            if (sphere.activeSelf == true) //Sphere->Prism
            {
                prism.transform.position = sphere.transform.position;
                sphere.SetActive(false);
                prism.SetActive(true);
            }
            else if (cube.activeSelf == true) //Cube->Prism
            {
                prism.transform.position = cube.transform.position;
                cube.SetActive(false);
                prism.SetActive(true);
            }

            else if (cone.activeSelf == true) //Cone->Prism
            {
                prism.transform.position = cone.transform.position;
                cone.SetActive(false);
                prism.SetActive(true);
            }

        }
    }


    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (sphere.activeSelf == true) //Sphere->Cone
            {
                cone.transform.position = sphere.transform.position;
                sphere.SetActive(false);
                cone.SetActive(true);
            }
            else if (cube.activeSelf == true) //Cube->Sphere
            {
                sphere.transform.position = cube.transform.position;
                cube.SetActive(false);
                sphere.SetActive(true);



            }

            else if (cone.activeSelf == true) //Cone->Prism
            {
                prism.transform.position = cone.transform.position + offset;
                cone.SetActive(false);
                prism.SetActive(true);
            }

            else if (prism.activeSelf == true) //Prism -> Cube
            {
                cube.transform.position = prism.transform.position + offset2;
                prism.SetActive(false);
                cube.SetActive(true);
            }
        }
        */

        Collider[] playersTouching = Physics.OverlapSphere(transform.position, 2, playerLayers);

        foreach (Collider thisObject in playersTouching)
        {
            shapeCollider();
        }
    }




}
