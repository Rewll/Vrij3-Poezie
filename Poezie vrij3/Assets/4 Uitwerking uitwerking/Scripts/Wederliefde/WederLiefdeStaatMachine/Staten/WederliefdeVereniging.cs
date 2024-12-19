using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class WederliefdeVereniging : WederLiefdeBasisStaat
{
    WederliefdeRegelaar regelaarRef;
    public float test;
    private void Start()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
    }

    public override void OnEnter()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
        GetComponent<WederLiefdeAgent>().huidigeStaat = WederLiefdeAgent.WederLiefdeFSMStaten.WederliefdeVereniging;       
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.RemoveAllListeners();
    }

    IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(1f);

    }

    public override void OnUpdate()
    {
        //alle stukjes slim lerpen
    }
    public override void OnExit()
    {

    }
}