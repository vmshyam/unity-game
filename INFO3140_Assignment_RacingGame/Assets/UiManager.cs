using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

    public Button[] gameFinishButtonsArray;
    public Text scoreText;
    int gameScore;
    bool gameOver;

	// Use this for initialization
	void Start () {
        gameScore = 0;
        gameOver = false;
        InvokeRepeating("ScoreUpdater",1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE: " + gameScore;

	}

    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void PlayGame()
    {
        //Application.LoadLevel("level_1");
        SceneManager.LoadScene("level_1");
    }

    public void ReplayGame()
    {
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene("level_1");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ExitGame()
    {
        EditorApplication.isPlaying = false;

        Application.Quit();
    }

    public void ScoreUpdater()
    {
        if (!gameOver)
        {
            gameScore += 1;
        }

    }

    public void GameOverAction()
    {
        gameOver = true;
        foreach (Button btn in gameFinishButtonsArray)
        {
            btn.gameObject.SetActive(true);
        }
    }
}
