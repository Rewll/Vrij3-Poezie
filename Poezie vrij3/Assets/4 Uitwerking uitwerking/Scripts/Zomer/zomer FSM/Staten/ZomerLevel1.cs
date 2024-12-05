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
    GameManagerOpslag regelaarOpslag;

    [SerializeField] private bool speler1Drukt;
    [SerializeField] private bool speler2Drukt;
    public List<KeyCode> knoppenSpeler1 = new List<KeyCode>();
    public List<KeyCode> knoppenSpeler2 = new List<KeyCode>();
  
    private void Awake()
    {
        regelaarOpslag = GetComponent<GameManagerOpslag>();
    }

    public override void OnEnter()
    {
        regelaarOpslag.speler2.GetComponent<ZomerBotsing>().bots.AddListener(BotsCheck);
        GetComponent<ZomerAgent>().huidigeStaat = ZomerAgent.ZomerFsmStaten.ZomerLevel1;
    }

    public override void OnUpdate()
    {

        speler1Drukt = regelaarOpslag.spelerDruktKnoppenInCheck(knoppenSpeler1);
        speler2Drukt = regelaarOpslag.spelerDruktKnoppenInCheck(knoppenSpeler2);
     
    }

    public void BotsCheck()
    {
        //Debug.Log("Bots Check vanuit : " + this.GetType().ToString());
        if (speler1Drukt && speler2Drukt)
        {
            Debug.Log("Met knoppen gebotst!");
            StartCoroutine(eindeRoutine());
        }
        else
        {
            Debug.Log("zonder knoppen gebotst");
        }
    }

    IEnumerator eindeRoutine()
    {
        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(ZomerLevel2));
    }

    public override void OnExit()
    {
        speler1Drukt = false;
        speler2Drukt = false;
        GetComponent<GameManagerOpslag>().speler2.GetComponent<ZomerBotsing>().bots.RemoveAllListeners();      
    }
}