using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class LenteStuk1Staat : LenteBasisStaat
{
    public GameObject kamera;
    [Space]
    public Transform speler1StartPlek;
    public Transform speler2StartPlek;
    [Space]
    public Image fadeVlak1;
    public Image fadeVlak2;
    [Space]
    public GameObject bloem1;
    public GameObject bloem2;
    [Space]
    public int opraapTeller;

    private void Start()
    {
        Tween fade1 = fadeVlak1.DOFade(1, 0.0001f);
        Tween fade2 = fadeVlak2.DOFade(1, 0.0001f);
    }

    public override void OnEnter()
    {
        kamera.SetActive(true);
        GetComponent<GameManagerOpslag>().verplaatsSpelers(speler1StartPlek.position, speler2StartPlek.position);
        //Fade de vlakken weg
        //Laat bloem verschijnen
        StartCoroutine(bloemFadeCoroutine());
    }

    IEnumerator bloemFadeCoroutine()
    {
        Tween fade1 = fadeVlak1.DOFade(0, 1);
        Tween fade2 = fadeVlak2.DOFade(0, 1);
        yield return fade1.WaitForCompletion();
        bloem1.GetComponent<bloem>().faden();
        bloem2.GetComponent<bloem>().faden();
        //Debug.Log("bloem tijd");
    }

    public override void OnUpdate()
    {

    }

    public void naOprapen1()
    {
        Tween fade1 = fadeVlak1.DOFade(1, 2);
        opraapTeller++;
        if (opraapTeller >= 2)
        {
            Debug.Log("Volgende !");
            VolgendeStukkie();
        }
    }

    public void naOprapen2()
    {
        Tween fade2 = fadeVlak2.DOFade(1, 2);
        opraapTeller++;
        if (opraapTeller >= 2)
        {
            Debug.Log("Volgende !");
            VolgendeStukkie();
        }
    }

    public void VolgendeStukkie()
    {
        StartCoroutine(volgendeStaatRoutine());
    }
    IEnumerator volgendeStaatRoutine()
    {
        yield return new WaitUntil(() => DOTween.TotalPlayingTweens() == 0);
        Debug.Log("Tweens klaar");
        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(LenteVeldStaat));
    }
    public override void OnExit()
    {
        kamera.SetActive(false);
    }
}