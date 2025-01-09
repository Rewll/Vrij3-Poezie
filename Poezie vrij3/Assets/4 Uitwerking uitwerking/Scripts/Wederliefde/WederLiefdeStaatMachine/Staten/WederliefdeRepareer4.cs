using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class WederliefdeRepareer4 : WederLiefdeBasisStaat
{
    WederliefdeRegelaar regelaarRef;
    bool magBotsen;
    [Space]
    public KeyCode Speler1Knop;
    public KeyCode Speler2Knop;
    [Space]
    public float spelerTerugSlagHoeveelHeid;
    public float stukjesKlikDuur;
    [Space]
    public Transform terugVliegPlek1;
    public Transform terugVliegPlek2;

    private void Start()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
    }

    public override void OnEnter()
    {
        GetComponent<WederLiefdeAgent>().huidigeStaat = WederLiefdeAgent.WederLiefdeFSMStaten.WederliefdeRepareer4;
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
        regelaarRef.alsSuccesVolleBots.Invoke();
        //regelaarRef.spelersTerugSlag(spelerTerugSlagHoeveelHeid);
        regelaarRef.speler1.transform.DOMove(terugVliegPlek1.position,2);
        regelaarRef.speler2.transform.DOMove(terugVliegPlek2.position, 2);

        yield return new WaitForSeconds(.5f);
        regelaarRef.knopIndicatorsUitZetten(1f);
        regelaarRef.stukjesRepareer(regelaarRef.stuk4A, regelaarRef.stuk4B,
                                    regelaarRef.plek4A, regelaarRef.plek4B,
                                    stukjesKlikDuur);
        yield return new WaitForSeconds(stukjesKlikDuur);
        //yield return new WaitUntil(() => DOTween.TotalActiveTweens() == 0);

        regelaarRef.stuk4.SetActive(true);
        regelaarRef.stuk4A.SetActive(false);
        regelaarRef.stuk4B.SetActive(false);

        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(WederliefdeVereniging));
    }

    public override void OnUpdate()
    {

    }
    public override void OnExit()
    {
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.RemoveAllListeners();
    }
}