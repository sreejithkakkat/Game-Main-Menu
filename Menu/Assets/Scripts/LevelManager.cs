using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    /*private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }*/
    public void Play()
    {
         SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}