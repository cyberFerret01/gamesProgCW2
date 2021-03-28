using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBlock : MonoBehaviour
{
    public GameObject playerBlock;
    public GameObject playerSphere;
    public GameObject playerCamera;
    GameObject spherePlayer;
    private bool isSphere = false;
    private Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {   
        playerPosition.x = playerBlock.transform.position.x;
        playerPosition.y = playerBlock.transform.position.y;
        playerPosition.z = playerBlock.transform.position.z;

        if (isSphere)
        {
            Destroy(playerBlock);
            spherePlayer = Instantiate(playerSphere, playerPosition, Quaternion.identity);
            playerCamera.GetComponent<PlayerCamera>().Switch(spherePlayer);
        }
        isSphere = false;
    }

    public void Sphere()
    {
        isSphere = true;
    }
}
