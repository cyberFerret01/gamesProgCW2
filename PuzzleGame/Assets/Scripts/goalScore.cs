using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallHit : MonoBehaviour
{
    Vector3 originalPos;
    public Transform Player;

    void Start()
    {
        originalPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
        //alternatively, just: originalPos = gameObject.transform.position;

    }
   void OnCollisionEnter(Collision Player)
    { if (Player.gameObject.tag == "Wall"
       )
        {
            gameObject.transform.position = originalPos;
        }

    }
}
