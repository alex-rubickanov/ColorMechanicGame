using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(8);
    }

    public void RestartLevel2()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartTutorial()
    {
        SceneManager.LoadScene(8);
    }

     public void RestartLevel1()
    {
        SceneManager.LoadScene(2);
    }
}
