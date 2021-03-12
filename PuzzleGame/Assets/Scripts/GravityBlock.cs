﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBlock : MonoBehaviour
{

    public GameObject player;
    public bool gravityInverted = false;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 10f;


    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gravityInverted == true)
        {
            //Physics.gravity = new Vector3(0, -1.0F, 0);
            m_Rigidbody.useGravity = false;
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }
        else
        {
            gravityInverted = false;
        }
    }

    public void InvertGravity()
    {
        gravityInverted = true;
        Debug.Log("yes");
    }
}
