using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IndicatorOpslag : MonoBehaviour
{
    public KeyCode knop;
    public TMP_Text knopLetter;
    public GameObject indicatieVlak;

    public void indicatorInstel()
    {
        knopLetter.text = knop.ToString();
    }
    private void Update()
    {
        if (Input.GetKey(knop))
        {
            indicatieVlak.SetActive(true);
        }
        else
        {
            indicatieVlak.SetActive(false);
        }
    }
}