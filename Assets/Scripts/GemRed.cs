using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemRed : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;
    public GameObject finalPlatform;
    void OnTriggerEnter()
    {
        GemGreen.counter++;
        GlobalScore.currentScore += 300;
        collectSound.Play();
        if (GemGreen.counter == 6)
        {
            if (finalPlatform.activeSelf == false)
            {
                finalPlatform.SetActive(true);
            }
        }
        Destroy(gameObject);
    }

}
