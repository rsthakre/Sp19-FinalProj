using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGemTrigger : MonoBehaviour
{
    public GameObject allRedGems;
    void OnTriggerEnter()
    {
        if(allRedGems.activeSelf == false){
            allRedGems.SetActive(true);
        }
    }
}
