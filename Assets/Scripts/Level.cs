﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("GameStart");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadGameOver()
    {
        StartCoroutine(GameOverCoroutine());
    }

    public void Quit()
    {
        Application.Quit();
    }

    private IEnumerator GameOverCoroutine()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameOver");
    }

}
