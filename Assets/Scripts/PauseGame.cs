using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pauseAudio;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                pauseAudio.Play();
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                
            }
            else
            {
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
                

            }
        }
    }


    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("Level01");

    }
    public void RestartLevel2()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("Level02");
    }

    public void RestartLevel3() 
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        GemGreen.counter = 0;
        SceneManager.LoadScene("Level03");
    }


    public void QuitToMenu()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = true;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
}
