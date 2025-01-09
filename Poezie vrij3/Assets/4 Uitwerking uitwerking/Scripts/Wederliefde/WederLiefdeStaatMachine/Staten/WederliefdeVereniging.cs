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
    float maxAfstand;
    [Space]
    public float spelerTerugSlagHoeveelHeid;
    [Space]
    public GameObject hartHeelStilstaand;
    [Space]
    public Vector2 stuk1Start;
    public Transform stuk1Bestemming;
    [Space]
    public Vector2 stuk2Start;
    public Transform stuk2Bestemming;
    [Space]
    public Vector2 stuk3Start;
    public Transform stuk3Bestemming;
    [Space]
    public Vector2 stuk4Start;
    public Transform stuk4Bestemming;

    private void Start()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
    }

    public override void OnEnter()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
        GetComponent<WederLiefdeAgent>().huidigeStaat = WederLiefdeAgent.WederLiefdeFSMStaten.WederliefdeVereniging;       
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.RemoveAllListeners();
        regelaarRef.speler2.GetComponent<Botsing>().alsBots.AddListener(BotsUitvoer);

        maxAfstand = Vector2.Distance(regelaarRef.speler1.transform.position,
                                      regelaarRef.speler2.transform.position);

        stuk1Start = regelaarRef.stuk1.transform.position;
        stuk2Start = regelaarRef.stuk2.transform.position;
        stuk3Start = regelaarRef.stuk3.transform.position;
        stuk4Start = regelaarRef.stuk4.transform.position;

    }

    public void BotsUitvoer()
    {
        StartCoroutine(botsRoutine());
    }

    IEnumerator botsRoutine()
    {
        regelaarRef.alsSuccesVolleBots.Invoke();
        regelaarRef.spelersTerugSlag(spelerTerugSlagHoeveelHeid);
        regelaarRef.stuk1.SetActive(false);
        regelaarRef.stuk2.SetActive(false);
        regelaarRef.stuk3.SetActive(false);
        regelaarRef.stuk4.SetActive(false);
        hartHeelStilstaand.SetActive(true);
        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(WederliefdeBloem));
    }

    public override void OnUpdate()
    {
        regelaarRef.stuk1.transform.position = regelaarRef.lerper(stuk1Bestemming.position, stuk1Start, maxAfstand);
        regelaarRef.stuk2.transform.position = regelaarRef.lerper(stuk2Bestemming.position, stuk2Start, maxAfstand);
        regelaarRef.stuk3.transform.position = regelaarRef.lerper(stuk3Bestemming.position, stuk3Start, maxAfstand);
        regelaarRef.stuk4.transform.position = regelaarRef.lerper(stuk4Bestemming.position, stuk4Start, maxAfstand);
    }
    public override void OnExit()
    {

    }
}