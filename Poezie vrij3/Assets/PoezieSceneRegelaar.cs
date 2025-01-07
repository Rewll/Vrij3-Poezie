using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PoezieSceneRegelaar : MonoBehaviour
{
    public Image fadeVlak;
    [Space]
    public IndicatorOpslag indicatorRef1;
    public IndicatorOpslag indicatorRef2;
    [Space]
    public int volgendeSceneNummer;
    [Space]
    public KeyCode speler1Knop;
    public KeyCode speler2Knop;

    bool speler1Klaar;
    bool speler2Klaar;

    bool sceneIsGestart;
    bool sceneIsKlaar;
    private void Start()
    {
        indicatorRef1.knop = speler1Knop;
        indicatorRef1.indicatorInstel();
        indicatorRef2.knop = speler2Knop;
        indicatorRef2.indicatorInstel();

        fadeVlak.DOFade(1, 0.001f);
        indicatorRef1.fadeUitMethod(0.001f);
        indicatorRef2.fadeUitMethod(0.001f);

        StartCoroutine(beginScene());
    }

    private void Update()
    {
        knoppenBedoeling();
    }

    IEnumerator beginScene()
    {
        Debug.Log("beginne");
        yield return new WaitForSeconds(1f);
        Tween fadeTween = fadeVlak.DOFade(0, 3);
        yield return fadeTween.WaitForCompletion();
        indicatorRef1.fadeInMethod(2);
        indicatorRef2.fadeInMethod(2);
        indicatorRef1.actief = true;
        indicatorRef2.actief = true;
        sceneIsGestart = true;
    }

    IEnumerator eindigScene()
    {
        yield return new WaitForSeconds(1f);
        Tween fadeTween = fadeVlak.DOFade(1, 2);
        yield return fadeTween.WaitForCompletion();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(volgendeSceneNummer - 1);
    }

    void knoppenBedoeling()
    {
        if (!sceneIsKlaar)
        {
            if (Input.GetKey(speler1Knop))
            {
                speler1Klaar = true;
                indicatorRef1.actief = false;
            }
            if (Input.GetKey(speler2Knop))
            {
                speler2Klaar = true;
                indicatorRef2.actief = false;
            }

            if (speler1Klaar && speler2Klaar)
            {
                Debug.Log("bleg");
                sceneIsKlaar = true;
                StartCoroutine(eindigScene());
            }
        }
    }
}