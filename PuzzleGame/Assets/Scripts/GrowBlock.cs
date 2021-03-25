using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowBlock : MonoBehaviour
{

    public GameObject player;
    private bool isGrowing = false;
    private Vector3 scaleChange;
    private bool isShrinking = false;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(+0.002f, +0.002f, +0.002f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrowing == true && player.transform.localScale.y <= 1.0f)
        {
            player.transform.localScale += scaleChange;
        }
        else
        {
            isGrowing = false;
        }

        if (isShrinking == true && player.transform.localScale.y >= 0.5f)
        {
            player.transform.localScale -= scaleChange;
        }
        else
        {
            isShrinking = false;
        }
    }

    public void Shrink(Vector3 magnitude)
    {
        scaleChange = magnitude;
        isShrinking = true;
        Debug.Log("yes");
    }

    public void Grow(Vector3 magnitude)
    {
        scaleChange = magnitude;
        isGrowing = true;
        Debug.Log("yes");
    }
}
