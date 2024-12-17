using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class WinterStartStaat : WinterBasisStaat
{
    public Image fadeVlak;
    [Space]
    public TMP_Text tutorialTekst1;
    public TMP_Text tutorialTekst2;
    [Space]
    public TMP_Text eindeTekst;
    [Space]
    public bool anjerMachineKlaar;
    public bool narcisMachineKlaar;

    private void Start()
    {
        DOTween.SetTweensCapacity(2000, 100);
        tutorialTekst1.DOFade(0, 0.00001f);
        tutorialTekst2.DOFade(0, 0.00001f);
        fadeVlak.DOFade(1, 0.00001f);
        eindeTekst.DOFade(0, 0.00001f);
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
        tutorialTekst1.DOFade(1, 1f);
        tutorialTekst2.DOFade(1, 1f);
    }

    public override void OnUpdate()
    {
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
        Debug.Log("Scene Klaar!");
        eindeTekst.DOFade(1, .5f);
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