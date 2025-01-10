using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

public class ZomerLevel1 : ZomerBasisStaat
{
    ZomerOpslag regelaarOpslag;
    public TMP_Text tutorialTekst;
    [Space]
    [SerializeField] private bool speler1Drukt;
    [SerializeField] private bool speler2Drukt;
    public KeyCode knopSpeler1;
    public KeyCode knopSpeler2;
  
    private void Awake()
    {
        regelaarOpslag = GetComponent<ZomerOpslag>();
        tutorialTekst.DOFade(0, 0.0001f);
    }

    public override void OnEnter()
    {
        regelaarOpslag.speler2.GetComponent<Botsing>().alsBots.AddListener(BotsCheck);
        GetComponent<ZomerAgent>().huidigeStaat = ZomerAgent.ZomerFsmStaten.ZomerLevel1;

        StartCoroutine(startRoutine());
    }

    IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(2f);
        Tween fadeTween = tutorialTekst.DOFade(1, 1f);
        regelaarOpslag.knopIndicator1Init(knopSpeler1);
        regelaarOpslag.knopIndicator2Init(knopSpeler2);
    }

    public override void OnUpdate()
    {
        speler1Drukt = regelaarOpslag.spelerDruktKnopInCheck(knopSpeler1);
        speler2Drukt = regelaarOpslag.spelerDruktKnopInCheck(knopSpeler2);
    }

    public void BotsCheck()
    {
        ////Debug.Log("Bots Check vanuit : " + this.GetType().ToString());
        regelaarOpslag.BotsCheckGeneric(speler1Drukt, speler2Drukt, botsRoutine());
    }

    IEnumerator botsRoutine()
    {
        //bots effect!
        tutorialTekst.DOFade(0, 0.5f);
        regelaarOpslag.spelersTerugVliegen();
        regelaarOpslag.knopIndicatorsUitZetten(1);
        //hartSnellerGaan!
        //regelaarOpslag.hartAnimator.SetInteger("AnimatieNummer", 1);
        regelaarOpslag.animatieRegelRef.crossfade(1, 1f);
        regelaarOpslag.alsSuccesVolleBots.Invoke();
        yield return new WaitForSeconds(1.5f);
        owner.SwitchState(typeof(ZomerLevel2));
    }

    public override void OnExit()
    {
        speler1Drukt = false;
        speler2Drukt = false;
        regelaarOpslag.speler2.GetComponent<Botsing>().alsBots.RemoveAllListeners();      
    }
}