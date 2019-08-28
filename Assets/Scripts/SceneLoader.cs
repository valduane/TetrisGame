using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
       
        SceneManager.LoadScene(1);

    }

    public void LoadStartScene()
    {
        int SceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneIndex = 0);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void Game()
    {
        int SceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(SceneIndex);
    }

    public void GameMode()
    {
        SceneManager.LoadScene(3);
    }

    public void Choose_of_share()
    {
        SceneManager.LoadScene(4);
    }
}
