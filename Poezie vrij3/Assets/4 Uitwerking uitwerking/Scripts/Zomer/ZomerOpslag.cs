using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;


public class ZomerOpslag : MonoBehaviour
{
    public GameObject speler1;
    public GameObject speler2;
    [Space]
    public GameObject knopIndicator1;
    public GameObject knopIndicator2;
    [Space]
    //public Animator hartAnimator;
    public AnimatieRegelBedoeling animatieRegelRef;
    [Space]
    public UnityEvent alsSuccesVolleBots;

    public bool spelerDruktKnopInCheck(KeyCode knop)
    {
        if (Input.GetKey(knop))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void spelersTerugVliegen()
    {
        speler1.GetComponent<SpelerBeweging>().beweegTerugBeetje(12);
        speler2.GetComponent<SpelerBeweging>().beweegTerugBeetje(12);
    }

    public void knopIndicatorsUitZetten(float fadeSnelHeid)
    {
        knopIndicator1.GetComponent<IndicatorOpslag>().fadeUitMethod(fadeSnelHeid);
        knopIndicator2.GetComponent<IndicatorOpslag>().fadeUitMethod(fadeSnelHeid);
    }

    public void knopIndicator1Init(KeyCode knop)
    {
        knopIndicator1.GetComponent<IndicatorOpslag>().knop = knop;
        knopIndicator1.GetComponent<IndicatorOpslag>().indicatorInstel();
        knopIndicator1.GetComponent<IndicatorOpslag>().fadeInMethod(1);
    }

    public void knopIndicator2Init(KeyCode knop)
    {
        knopIndicator2.GetComponent<IndicatorOpslag>().knop = knop;
        knopIndicator2.GetComponent<IndicatorOpslag>().indicatorInstel();
        knopIndicator2.GetComponent<IndicatorOpslag>().fadeInMethod(1);
    }

    public void BotsCheckGeneric(bool speler1, bool speler2, IEnumerator botsRoutine)
    {
        //Debug.Log("Bots Check vanuit : " + this.GetType().ToString());
        if (speler1 && speler2)
        {
            Debug.Log("Met knoppen gebotst!");
            StartCoroutine(botsRoutine);
        }
        else
        {
            Debug.Log("zonder knoppen gebotst");
        }
    }
}