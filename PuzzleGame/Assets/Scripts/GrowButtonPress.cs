﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowButtonPress : MonoBehaviour
{

    public Transform centrePoint;
    public float pressRange = 0.5f;
    public LayerMask playerLayers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        buttonPressed();
    }

    void buttonPressed()
    {

        Collider[] playersTouching = Physics.OverlapSphere(centrePoint.position, pressRange, playerLayers);

        foreach (Collider player in playersTouching)
        {
            player.GetComponent<GrowBlock>().Grow(new Vector3(+0.002f, +0.002f, +0.002f));
        }
    }


}
