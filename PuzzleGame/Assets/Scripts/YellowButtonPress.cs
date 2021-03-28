using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowButtonPress : MonoBehaviour
{

    public Transform centrePoint;
    public float pressRange = 4f;
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

        Collider[] playersTouching = Physics.OverlapSphere(centrePoint.position, 2, playerLayers);

        foreach (Collider player in playersTouching)
        {
            player.GetComponent<YellowBlock>().PassThroughYellowWall();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Use the same vars you use to draw your Overlap SPhere to draw your Wire Sphere.
        Gizmos.DrawWireSphere(centrePoint.position, 2);
    }

}
