using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class Level2Staat : BaseState
{
    public GameObject Level2Camera;
    [Space]
    public Transform speler1StartPlek;
    public Transform speler2StartPlek;
    [Space]
    public Image fadeVlak1;

    public override void OnEnter()
    {
        //spelers verplaatsen
        GetComponent<GameManagerOpslag>().verplaatsSpelers(speler1StartPlek.position, speler2StartPlek.position);
        //camera aan
        Level2Camera.SetActive(true);
        //Fade in
        fadeVlak1.DOFade(0, 2);
    }

    public override void OnUpdate()
    {
        //Verschijn poezie bij elke samenpluk
    }

    public override void OnExit()
    {

    }
}