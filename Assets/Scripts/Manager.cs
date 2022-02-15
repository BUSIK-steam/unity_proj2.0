using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{ 

    GameObject[] startGameUIComponents;
    GameObject[] gameOverUIComponents;
    [SerializeField] GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        startGameUIComponents = GameObject.FindGameObjectsWithTag("StartGameUIComponents");
        gameOverUIComponents = GameObject.FindGameObjectsWithTag("GameOverUIComponents");
        DisableUIComponents(gameOverUIComponents);
        EnableUIComponents(gameOverUIComponents);
        DisableScore(score);
        EnableScore(score);
        gameOver();
    }

    public void gameOver()
    {
        EnableUIComponents(gameOverUIComponents);
    }

    private void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }
    private void EnableScore(GameObject score)
    {
        score.SetActive(true);
    }
    private void DisableUIComponents(GameObject[] gameOverUIComponents)
    {
        foreach (GameObject obj in gameOverUIComponents)
        {
            obj.SetActive(false);
        }
    }
    private void EnableUIComponents(GameObject[] gameOverUIComponents)
    {
        foreach(GameObject obj in startGameUIComponents)
        {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
