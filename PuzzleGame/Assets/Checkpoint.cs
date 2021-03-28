using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject correctShape;
    public bool checkPointReached;
    // Start is called before the first frame update
    void Start()
    {
        checkPointReached = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("From Checkpoint: " + checkPointReached);
        if (Vector3.Distance(correctShape.transform.position, this.transform.position) < 2)
        {
            checkPointReached = true;
        }
    }

    public bool IsCheckPointReached()
    {
        return checkPointReached;
    }
}
