using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class WederliefdeRepareer3 : WederLiefdeBasisStaat
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
        GetComponent<WederLiefdeAgent>().huidigeStaat = WederLiefdeAgent.WederLiefdeFSMStaten.WederliefdeRepareer3;
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.AddListener(BotsUitvoer);

        StartCoroutine(startRoutine());
    }
    IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(1f);
        regelaarRef.knopIndicator1Init(Speler1Knop);
        regelaarRef.knopIndicator2Init(Speler2Knop);
        regelaarRef.knopIndicatorsInFaden(1f);
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
        regelaarRef.stukjesRepareer(regelaarRef.stuk3A, regelaarRef.stuk3B,
                                    regelaarRef.plek3A, regelaarRef.plek3B,
                                    stukjesKlikDuur);
        yield return new WaitUntil(() => DOTween.TotalActiveTweens() == 0);

        regelaarRef.stuk3.SetActive(true);
        regelaarRef.stuk3A.SetActive(false);
        regelaarRef.stuk3B.SetActive(false);

        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(WederliefdeRepareer4));
    }

    public override void OnUpdate()
    {

    }
    public override void OnExit()
    {
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.RemoveAllListeners();
    }
}
