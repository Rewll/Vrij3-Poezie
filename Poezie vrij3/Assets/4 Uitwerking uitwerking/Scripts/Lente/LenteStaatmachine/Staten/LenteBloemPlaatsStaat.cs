using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

public class LenteBloemPlaatsStaat : LenteBasisStaat
{
    GameManagerOpslag GO;

    public Transform speler1StartPlek;
    public Transform speler2StartPlek;
    [Space]
    public GameObject hart;
    public Transform hartPlek;
    public GameObject hartMetKleur;
    public GameObject laatsteZonderKleur;
    [Space]
    public UnityEvent bloemSmeltNaar1;
    public override void OnEnter()
    {
        GO = GetComponent<GameManagerOpslag>();
        //GO.verplaatsSpelers(speler1StartPlek.position, speler2StartPlek.position);

        hartPlek.gameObject.SetActive(true);
        hart.transform.DOMove(hartPlek.position, 1);
        //Spelers bloemen worden 1 bloem
        bloemSmeltNaar1.Invoke();
    }

    public override void OnUpdate()
    {
        
    }

    public override void OnExit()
    {
        
    }

    public void machineStart()
    {
        StartCoroutine(machineStartRoutine());
    }

    IEnumerator machineStartRoutine()
    {
        yield return new WaitForSeconds(1f);
        laatsteZonderKleur.SetActive(false);
        hartMetKleur.SetActive(true);
        yield return new WaitForSeconds(1f);
        //animatie starten 
    }
}