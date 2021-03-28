using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    private bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        if(position.y <= -5.0f)
        {
            isDead = true;
        }
    }

    public bool IsDead()
    {
        return isDead;
    }
}
