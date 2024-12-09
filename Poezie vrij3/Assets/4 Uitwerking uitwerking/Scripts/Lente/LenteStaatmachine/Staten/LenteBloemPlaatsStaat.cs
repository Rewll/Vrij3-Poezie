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
    public GameObject hart;
    public Transform hartPlek;
    public UnityEvent bloemSmeltNaar1;
    public override void OnEnter()
    {
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
}