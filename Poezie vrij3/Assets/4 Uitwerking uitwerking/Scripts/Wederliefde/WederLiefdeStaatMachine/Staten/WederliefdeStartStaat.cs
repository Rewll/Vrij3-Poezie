using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class WederliefdeStartStaat : WederLiefdeBasisStaat
{
    WederliefdeRegelaar regelaarRef;

    private void Start()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
        regelaarRef.stuk1.SetActive(false);
        regelaarRef.stuk2.SetActive(false);
        regelaarRef.stuk3.SetActive(false);
        regelaarRef.stuk4.SetActive(false);
    }

    public override void OnEnter()
    {
        GetComponent<WederLiefdeAgent>().huidigeStaat = WederLiefdeAgent.WederLiefdeFSMStaten.WederliefdeStartStaat;
        Tween fadeTween = regelaarRef.fadeVlak.DOFade(1, 0.00001f);
        regelaarRef.knopIndicatorsUitZetten(0.0000001f);
        StartCoroutine(startRoutine());
    }

    IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(2f);
        Tween fadeTween = regelaarRef.fadeVlak.DOFade(0, 2f);
        yield return fadeTween.WaitForCompletion();
        //stukjes laten zien
        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(WederliefdeRepareer1));
    }

    public override void OnUpdate()
    {
        
    }
    public override void OnExit()
    {

    }
}