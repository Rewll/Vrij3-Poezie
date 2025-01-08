using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class WederliefdeRepareer2 : WederLiefdeBasisStaat
{
    WederliefdeRegelaar regelaarRef;
    bool magBotsen;
    [Space]
    public KeyCode Speler1Knop;
    public KeyCode Speler2Knop;
    [Space]
    public float spelerTerugSlagHoeveelHeid;
    public float stukjesKlikDuur;

    private void Start()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
    }

    public override void OnEnter()
    {
        GetComponent<WederLiefdeAgent>().huidigeStaat = WederLiefdeAgent.WederLiefdeFSMStaten.WederliefdeRepareer2;
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.AddListener(BotsUitvoer);

        StartCoroutine(startRoutine());
    }
    IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(1f);
        regelaarRef.knopIndicator1Init(Speler1Knop);
        regelaarRef.knopIndicator2Init(Speler2Knop);
        regelaarRef.knopIndicatorsInFaden(2f);
        yield return new WaitForSeconds(2f);
        magBotsen = true;
    }
    public void BotsUitvoer()
    {
        if (magBotsen)
        {
            if (Input.GetKey(Speler1Knop) && Input.GetKey(Speler2Knop))
            {
                StartCoroutine(botsRoutine());
            }
        }
    }

    IEnumerator botsRoutine()
    {
        regelaarRef.spelersTerugSlag(spelerTerugSlagHoeveelHeid);
        yield return new WaitForSeconds(.5f);
        regelaarRef.knopIndicatorsUitZetten(1f);
        regelaarRef.stukjesRepareer(regelaarRef.stuk2A, regelaarRef.stuk2B,
                                    regelaarRef.plek2A, regelaarRef.plek2B,
                                    stukjesKlikDuur);
        yield return new WaitUntil(() => DOTween.TotalActiveTweens() == 0);

        regelaarRef.stuk2.SetActive(true);
        regelaarRef.stuk2A.SetActive(false);
        regelaarRef.stuk2B.SetActive(false);

        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(WederliefdeRepareer3));
    }


    public override void OnUpdate()
    {

    }
    public override void OnExit()
    {
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.RemoveAllListeners();
    }
}
