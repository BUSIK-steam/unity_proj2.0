using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void ReloadLevel()
    {
        // одно и то же
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(0);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene(2);
        ResumeGame();
    }

    public void Exit() { Application.Quit(); }

    private void ResumeGame() { Time.timeScale = 1; }

}
