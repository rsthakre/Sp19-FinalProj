using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{

    public GameObject youFell;
    public GameObject levelAudio;
    public GameObject fadeOut;
    public GameObject redGems;
    public bool isLevel3;

    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
    }

    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        levelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        if (isLevel3)
        {
            GemGreen.counter = 0;
            redGems.SetActive(false);
        }
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}