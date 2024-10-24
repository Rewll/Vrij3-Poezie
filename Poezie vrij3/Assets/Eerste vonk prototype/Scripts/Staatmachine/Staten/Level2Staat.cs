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
    [Space]
    public int dichtbijKlikTeller;
    public List<GameObject> stukjesPoezie = new List<GameObject>();
    public Tween poezieFade;

    private void Start()
    {
        foreach (GameObject tekst in stukjesPoezie)
        {
            tekst.GetComponent<TMP_Text>().DOFade(0, 0.001f);
        }
    }

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

    }

    public override void OnExit()
    {

    }

    public void volgendePoezie()
    {
        if (dichtbijKlikTeller < stukjesPoezie.Count)
        {
            stukjesPoezie[dichtbijKlikTeller].GetComponent<TMP_Text>().DOFade(1, 2);
            dichtbijKlikTeller++;
        }
    }
}