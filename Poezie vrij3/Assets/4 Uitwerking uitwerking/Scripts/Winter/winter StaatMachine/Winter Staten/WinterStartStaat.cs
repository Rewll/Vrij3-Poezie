using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;

public class WinterStartStaat : WinterBasisStaat
{
    public Image fadeVlak;
    [Space]
    public TMP_Text bouwUitlegTekst;
    public TMP_Text knopTekst1;
    public TMP_Text knopTekst2;
    [Space]
    public bool anjerMachineKlaar;
    public bool narcisMachineKlaar;

    private void Start()
    {
        DOTween.SetTweensCapacity(2000, 100);
        bouwUitlegTekst.DOFade(0, 0.00001f);
        knopTekst1.DOFade(0, 0.00001f);
        knopTekst2.DOFade(0, 0.00001f);
        fadeVlak.DOFade(1, 0.00001f);
    }

    public override void OnEnter()
    {
        //fade in bedoeling
        //tutorialtekstbedoeling
        StartCoroutine(startRoutine());
    }

    IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(1f);
        Tween fadeTween = fadeVlak.DOFade(0, 2f);
        yield return fadeTween.WaitForCompletion();
        yield return new WaitForSeconds(1f);
        bouwUitlegTekst.DOFade(1, 1f);
        knopTekst1.DOFade(1, 1f);
        knopTekst2.DOFade(1, 1f);
    }

    public override void OnUpdate()
    {
        if (!knopTekst1.gameObject.activeInHierarchy && !knopTekst2.gameObject.activeInHierarchy)
        {
            bouwUitlegTekst.DOFade(0,2f);
        }
        if (anjerMachineKlaar && narcisMachineKlaar)
        {
            narcisMachineKlaar = false;
            anjerMachineKlaar = false;
            StartCoroutine(klaarRoutine());
        }
    }

    IEnumerator klaarRoutine()
    {
        yield return new WaitForSeconds(2f);
        Tween fadeTween = fadeVlak.DOFade(1, 4f);
        yield return fadeTween.WaitForCompletion();
        SceneManager.LoadScene(9);
    }

    public override void OnExit()
    {
        
    }

    public void anjerMachineKlaarOpTrue()
    {
        anjerMachineKlaar = true;
    }
    public void narcisMachineKlaarOpTrue()
    {
        narcisMachineKlaar = true;
    }
}