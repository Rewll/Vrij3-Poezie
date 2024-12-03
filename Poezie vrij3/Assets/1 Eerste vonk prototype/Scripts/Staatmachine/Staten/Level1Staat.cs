using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class Level1Staat : BaseState
{
    public GameObject Level1Camera;
    [Space]
    public Transform speler1StartPlek;
    public Transform speler2StartPlek;
    [Space]
    public Image fadeVlak1; 
    public Image fadeVlak2;
    [Space]
    public GameObject bloem1;
    public GameObject bloem2;
    [Space]
    public int opraapTeller;

    public override void OnEnter()
    {
        //Debug.Log("hoi");
        //Camera aan
        Level1Camera.SetActive(true);
        //Verplaats spelers
        GetComponent<GameManagerOpslag>().verplaatsSpelers(speler1StartPlek.position, speler2StartPlek.position);
        //Fade de vlakken weg
        //Laat bloem verschijnen
        StartCoroutine(bloemFadeCoroutine());
    }

    IEnumerator bloemFadeCoroutine()
    {
        Tween fade1 = fadeVlak1.DOFade(0, 2);
        Tween fade2 = fadeVlak2.DOFade(0, 2);
        //Debug.Log(DOTween.TotalActiveSequences());
        //yield return new WaitUntil(() => fade1.() && fade2.IsComplete());
        yield return fade1.WaitForCompletion();
        bloem1.GetComponent<bloem>().faden();
        bloem2.GetComponent<bloem>().faden();
        Debug.Log("bloem tijd");
    }

    public override void OnUpdate()
    {
        // Als geplukt: weer fade naar zwart
        //Als beide spelers de tweede geplukt hebben: naar volgende staat
        if (GetComponent<GameManagerOpslag>().Speler1Opgeraapt)
        {
            //Debug.Log("Speler 1 opgeraapt");
            opraapTeller++;
            GetComponent<GameManagerOpslag>().Speler1Opgeraapt = false;
            fadeVlak1.DOFade(1, 2);
        }
        if (GetComponent<GameManagerOpslag>().Speler2Opgeraapt)
        {
            //Debug.Log("Speler 2 opgeraapt");
            opraapTeller++;
            GetComponent<GameManagerOpslag>().Speler2Opgeraapt = false;
            fadeVlak2.DOFade(1, 2);
        }
        int tmp = DOTween.TotalActiveTweens();
        if (opraapTeller >= 2 && tmp == 0)
        {
            //Debug.Log("De wereld draait doorrrrrrrrrrrrrrrr");
            opraapTeller = 0;
            owner.SwitchState(typeof(Level2Staat));
        }
    }

    public override void OnExit()
    {
        //Camerauit
        Level1Camera.SetActive(false);
    }
}