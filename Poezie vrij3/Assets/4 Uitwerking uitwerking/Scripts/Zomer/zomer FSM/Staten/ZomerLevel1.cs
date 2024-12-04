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
    private Besturing besturing;
    [SerializeField] private bool speler1Drukt;
    [SerializeField] private bool speler2Drukt;
  
    private void Awake()
    {
        besturing = new Besturing();
    }

    public override void OnEnter()
    {
        GetComponent<GameManagerOpslag>().speler2.GetComponent<ZomerBotsing>().bots.AddListener(BotsCheck);
    }

    public override void OnUpdate()
    {       
        speler1Drukt = speler1DruktAlles();
        speler2Drukt = speler2DruktAlles();


        //Debug.Log(besturing.ZomerSpeler1A.Knop1.GetBindingDisplayString());        
    }

    bool speler1DruktAlles()
    {
        if (besturing.ZomerSpeler1A.Knop1.ReadValue<float>() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool speler2DruktAlles()
    {
        if (besturing.ZomerSpeler2A.Knop1.ReadValue<float>() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void BotsCheck()
    {
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

    }
    private void OnEnable()
    {
        besturing.Enable();
    }

    private void OnDisable()
    {
        besturing.Disable();
    }
}