using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageMove : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }
    int speed = 3; // Adjust to make your NPC move however fast you want.


    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
