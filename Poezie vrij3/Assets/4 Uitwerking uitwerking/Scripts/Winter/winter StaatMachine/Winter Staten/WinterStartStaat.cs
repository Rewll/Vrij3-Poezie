using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;


public class WinterStartStaat : WinterBasisStaat
{
    public Image fadeVlak;
    [Space]
    public bool anjerMachineKlaar;
    public bool narcisMachineKlaar;
    
    public override void OnEnter()
    {
        DOTween.SetTweensCapacity(2000, 100);
        //fade in bedoeling
        //tutorialtekstbedoeling
    }

    public override void OnUpdate()
    {
        if (anjerMachineKlaar && narcisMachineKlaar)
        {
            StartCoroutine(klaarRoutine());
        }
    }

    IEnumerator klaarRoutine()
    {
        yield return new WaitForSeconds(2f);
        Tween fadeTween = fadeVlak.DOFade(1, 4f);
        yield return fadeTween.WaitForCompletion();
        Debug.Log("Scene Klaar!");
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