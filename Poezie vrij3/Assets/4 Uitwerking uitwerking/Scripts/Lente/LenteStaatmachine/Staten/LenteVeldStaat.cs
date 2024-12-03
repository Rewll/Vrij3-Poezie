using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class LenteVeldStaat : LenteBasisStaat
{
    GameManagerOpslag GO;

    public GameObject kamera;
    [Space]
    public Transform speler1StartPlek;
    public Transform speler2StartPlek;
    [Space]
    public Image fadeVlak1;
    [Space]
    public SpriteRenderer bloemtjs;
    [Space]
    public float maxAfstand;
    public float afstand;
    [Space]
    public List<GameObject> hartOnderdelen = new List<GameObject>();
    public List<Transform> hartOnderdelenPlekken = new List<Transform>();
    public int hartVerschijnTeller;
    public bool hartOntwikkelBezig;
    public Transform midden;

    private void Start()
    {
        foreach (GameObject stuk in hartOnderdelen)
        {
            stuk.SetActive(false);
        }
    }

    public override void OnEnter()
    {
        kamera.SetActive(true);
        GO = GetComponent<GameManagerOpslag>();
        GO.verplaatsSpelers(speler1StartPlek.position, speler2StartPlek.position);
        fadeVlak1.DOFade(0, 2);
    }

    public override void OnUpdate()
    {
        afstand = Vector2.Distance(GO.speler1.transform.position, GO.speler2.transform.position);
        float afstand2 = Mathf.Min(Vector2.Distance(GO.speler1.transform.position, GO.speler2.transform.position), maxAfstand);
        bloemtjs.color = new Color(bloemtjs.color.r, bloemtjs.color.g, bloemtjs.color.b, 1 - (afstand2 / maxAfstand));
    }

    public void hartOntwikkel()
    {
        if (!hartOntwikkelBezig)
        {
            if (hartVerschijnTeller < hartOnderdelen.Count)
            {
                StartCoroutine(hartOntwikkelRoutine());
            }
            else if (hartVerschijnTeller >= hartOnderdelen.Count)
            {
                //owner.SwitchState(typeof(HartPlaatsFase));
                StartCoroutine(hartKlaar());
            }
        }
    }
    IEnumerator hartOntwikkelRoutine()
    {
        hartOntwikkelBezig = true;
        hartOnderdelen[hartVerschijnTeller].SetActive(true);
        hartOnderdelen[hartVerschijnTeller].transform.position = midden.position;
        Tween beweeg = hartOnderdelen[hartVerschijnTeller].transform.DOMove(hartOnderdelenPlekken[hartVerschijnTeller].position, 1f);
        yield return beweeg.WaitForCompletion();
        yield return new WaitForSeconds(0.1f);
        hartVerschijnTeller++;
        hartOntwikkelBezig = false;
    }

    IEnumerator hartKlaar()
    {
        yield return new WaitForSeconds(2);
        owner.SwitchState(typeof(LenteBloemPlaatsStaat)); 
    }

    public override void OnExit()
    {

    }
}