using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ReloadGame()
    {
        FindObjectOfType<PlayerHealth>().IsGameOver = false;
        SceneManager.LoadScene(0);
        FindObjectOfType<Waypoint>().enabled = true;
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
