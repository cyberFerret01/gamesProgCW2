using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFields : MonoBehaviour
{
    public GameObject button;
    public GameObject textBox;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (Vector3.Distance(player.transform.position, button.transform.position) < 9)
        {
            textBox.SetActive(true);
        }
        else
        {
            textBox.SetActive(false);
        }
    }
}
