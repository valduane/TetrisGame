using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void GameMode()
    {
        SceneManager.LoadScene("GameMode");
    }

    public void Choose_of_share()
    {
        SceneManager.LoadScene("Choose_of_share");
    }
}
