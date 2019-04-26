using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{

    public AudioSource buttonPress;
    public int bestScore;
    public GameObject bestScoreDisplay;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    public void PlayGame()
    {
        Cursor.visible = false;
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCreds()
    {
        Cursor.visible = false;
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }

    public void ResetBest()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        Cursor.visible = true;
        SceneManager.LoadScene(1);
    }
}