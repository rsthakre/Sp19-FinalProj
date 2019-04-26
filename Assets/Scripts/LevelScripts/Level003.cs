﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level003 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectToLevel.redirectToLevel = 7;
        RedirectToLevel.nextLevel = 6;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}