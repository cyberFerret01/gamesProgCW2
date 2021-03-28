using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public float transitionTime = 0.1f;
    private bool checkpointReached;
    public GameObject checkpoint;
    public GameObject player;
    private bool isDead;

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        checkpointReached = checkpoint.GetComponent<Checkpoint>().IsCheckPointReached();
        Debug.Log(checkpointReached);
        //isDead = player.GetComponent<Dead>().IsDead();
        if (checkpointReached == true)
        {
            LoadNextLevel();
        }
        /*if (isDead)
        {
            ReloadLevel();
        }*/
    }

    public void ReloadLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
        //play anim
        //wait
        //load scene
    }
}
