using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Pause(GameObject PauseMenu)
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
            
        }
        else
        {
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
        }
    }

    public void MainScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Option(GameObject OptionMenu)
    {
        if (OptionMenu.activeInHierarchy == false)
            OptionMenu.SetActive(true);
        else
            OptionMenu.SetActive(false);
    }
}