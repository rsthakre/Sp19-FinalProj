using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{

    public GameObject theLogo;

    void Start()
    {
        Cursor.visible = false;
        StartCoroutine(RunSplash());
    }

    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(0.5f);
        theLogo.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        Cursor.visible = true;
        SceneManager.LoadScene(1);
    }

}