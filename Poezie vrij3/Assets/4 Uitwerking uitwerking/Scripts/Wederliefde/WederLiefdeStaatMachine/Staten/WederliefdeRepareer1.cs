using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class WederliefdeRepareer1 : WederLiefdeBasisStaat
{
    WederliefdeRegelaar regelaarRef;
    bool magBotsen;
    [Space]
    public float spelerTerugSlagHoeveelHeid;
    public float stukjesKlikDuur;

    private void Start()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
    }

    public override void OnEnter()
    {
        GetComponent<WederLiefdeAgent>().huidigeStaat = WederLiefdeAgent.WederLiefdeFSMStaten.WederliefdeRepareer1;
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.AddListener(BotsUitvoer);
        StartCoroutine(startRoutine());
    }
    IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(1f);
        magBotsen = true;

    }
    public void BotsUitvoer()
    {
        if (magBotsen)
        {
            StartCoroutine(botsRoutine());
        }   
    }

    IEnumerator botsRoutine()
    {
        magBotsen = false;
        regelaarRef.alsSuccesVolleBots.Invoke();
        regelaarRef.spelersTerugSlag(spelerTerugSlagHoeveelHeid);
        yield return new WaitForSeconds(.5f);
        //stukjes in elkaar klik
        regelaarRef.stukjesRepareer(regelaarRef.stuk1A, regelaarRef.stuk1B, 
                                    regelaarRef.plek1A, regelaarRef.plek1B, 
                                    stukjesKlikDuur);
        yield return new WaitUntil(() => DOTween.TotalActiveTweens() == 0);

        regelaarRef.stuk1.SetActive(true);
        regelaarRef.stuk1A.SetActive(false);
        regelaarRef.stuk1B.SetActive(false);

        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(WederliefdeRepareer2));
    }

    public override void OnUpdate()
    {

    }

    public override void OnExit()
    {
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.RemoveAllListeners();
    }
}