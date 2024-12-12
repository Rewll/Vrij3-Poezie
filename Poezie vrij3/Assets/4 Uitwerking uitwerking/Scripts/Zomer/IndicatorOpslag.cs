using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class IndicatorOpslag : MonoBehaviour
{
    public KeyCode knop;
    [Space]
    public bool actief;
    public Image kleurVlak;
    public GameObject indicatieVlak;
    public TMP_Text knopLetter;

    public void indicatorInstel()
    {
        knopLetter.text = knop.ToString();
    }
    private void Update()
    {
        if (actief)
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
        else
        {
            indicatieVlak.SetActive(false);
        }
    }

    public void fadeInMethod(float fadeSnelHeid)
    {
        StartCoroutine(fadeIn(fadeSnelHeid));
    }
    public IEnumerator fadeIn(float fadeSnelHeid)
    {
        kleurVlak.DOFade(1, fadeSnelHeid);
        indicatieVlak.GetComponent<Image>().DOFade(1, fadeSnelHeid);
        Tween letterFade = knopLetter.DOFade(1, fadeSnelHeid);
        yield return letterFade.WaitForCompletion();
        actief = true;
    }
    public void fadeUitMethod(float fadeSnelHeid)
    {
        StartCoroutine(fadeUit(fadeSnelHeid));
    }
    public IEnumerator fadeUit(float fadeSnelHeid)
    {
        actief = false;
        kleurVlak.DOFade(0, fadeSnelHeid);
        indicatieVlak.GetComponent<Image>().DOFade(0, fadeSnelHeid);
        Tween letterFade = knopLetter.DOFade(0, fadeSnelHeid);
        yield return letterFade.WaitForCompletion();
    }
}