using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;
    public GameObject finalPlatform;
    public static int counter = 0;
    void OnTriggerEnter()
    {
        counter++;
        GlobalScore.currentScore += 500;
        collectSound.Play();
        if (counter == 6)
        {
            if (finalPlatform.activeSelf == false)
            {
                finalPlatform.SetActive(true);
            }
        }
        Destroy(gameObject);
    }

}
