using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterTrigger : MonoBehaviour
{
    public GameObject floaterPlatform;
    void OnTriggerEnter()
    {
        if (floaterPlatform.activeSelf == false)
        {
            floaterPlatform.SetActive(true);
        }
    }
}
