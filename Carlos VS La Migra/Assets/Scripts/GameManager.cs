using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject DeadScreen;
    public  bool GameIsRunning = false;

    

    public void GameEnd()
    {
        DeadScreen.SetActive(true);
        GameIsRunning = true;

        Debug.Log("GameOver");
    }

    public void Repeat()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
