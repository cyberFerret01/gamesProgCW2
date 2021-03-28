using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarrativeMenu : MonoBehaviour
{
    private bool text1;
    private bool text2;
    private bool text3;
    private bool text4;
    private bool text5;
    public GameObject textbox1;
    public GameObject textbox2;
    public GameObject textbox3;
    public GameObject textbox4;
    public GameObject textbox5;
    // Start is called before the first frame update
    void Start()
    {
        text1 = true;
        text2 = false;
        text3 = false;
        text4 = false;
        text5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(text1==true && Input.GetKeyDown(KeyCode.Return))
        {
            textbox1.SetActive(false);
            textbox2.SetActive(true);
            text2 = true;
            text1 = false;
        }
        else if (text2 == true && Input.GetKeyDown(KeyCode.Return))
        {
            textbox2.SetActive(false);
            textbox3.SetActive(true);
            text3 = true;
            text2 = false;
        }
        else if (text3 == true && Input.GetKeyDown(KeyCode.Return))
        {
            textbox3.SetActive(false);
            textbox4.SetActive(true);
            text4 = true;
            text3 = false;
        }
        else if (text4 == true && Input.GetKeyDown(KeyCode.Return) )
        {
            textbox4.SetActive(false);
            textbox5.SetActive(true);
            text5 = true;
            text4 = false;
        }
        else if (text5 == true && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
