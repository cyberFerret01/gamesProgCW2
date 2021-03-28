using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollide : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject cone;
    public GameObject prism;
    Vector3 originalPos;
    public Transform Player;

    void Start()
    {
        originalPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
        //alternatively, just: originalPos = gameObject.transform.position;

    }

   void OnCollisionEnter(Collision collision)
    { if (collision.gameObject.tag == "Wall")
        {
            gameObject.transform.position = originalPos;
        }

        if ((collision.gameObject.tag == "ColliderS") && (cone.active == true))
        {
            gameObject.transform.position = originalPos;

        }

        else if ((collision.gameObject.tag == "ColliderS") && (cube.active == true))
        {
            gameObject.transform.position = originalPos;
        }

        else if ((collision.gameObject.tag == "ColliderS") && (prism.active == true))
        {
            gameObject.transform.position = originalPos;
        }

        else if ((collision.gameObject.tag == "ColliderS") && (sphere.active == true))
        {
            Physics.IgnoreCollision(sphere.GetComponent<Collider>(), GetComponent<Collider>());
        }

        else if ((collision.gameObject.tag == "ColliderC") && (cone.active == true))
        {
            gameObject.transform.position = originalPos;

        }

        else if ((collision.gameObject.tag == "ColliderC") && (cube.active == true))
        {
            Physics.IgnoreCollision(cube.GetComponent<Collider>(), GetComponent<Collider>());
        }

        else if ((collision.gameObject.tag == "ColliderC") && (prism.active == true))
        {
            gameObject.transform.position = originalPos;
        }

        else if ((collision.gameObject.tag == "ColliderC") && (sphere.active == true))
        {
            gameObject.transform.position = originalPos;
        }
    }

    
}
