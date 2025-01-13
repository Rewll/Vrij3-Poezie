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
    public GameObject poeziestuk;
    public GameObject eersteNarcis;
    public GameObject eersteAnjer;
    private SpriteRenderer eersteAnjSR;
    private SpriteRenderer eersteNarcSR;
    private int teller;
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
        eersteAnjSR = eersteAnjer.transform.GetChild(0).GetComponent<SpriteRenderer>();
        eersteNarcSR = eersteNarcis.transform.GetChild(0).GetComponent<SpriteRenderer>();

        fadeVlak1.DOFade(1, 0.0001f);

        eersteAnjer.GetComponent<bloem>().uitFaden(0.0001f);
        eersteNarcis.GetComponent<bloem>().uitFaden(0.0001f);

        poeziestuk.GetComponent<SpriteRenderer>().DOFade(0, 0.0001f);

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
        StartCoroutine(startRoutine());
    }

    IEnumerator startRoutine()
    {
        Tween fadeTween = fadeVlak1.DOFade(0, 2);
        yield return fadeTween.WaitForCompletion();
        yield return new WaitForSeconds(1f);
        Tween poezieFade = poeziestuk.GetComponent<SpriteRenderer>().DOFade(1, 1);
        yield return poezieFade.WaitForCompletion();
        yield return new WaitForSeconds(3f);
        eersteNarcis.GetComponent<bloem>().faden();
        eersteAnjer.GetComponent<bloem>().faden();
    }

    public void terugFade()
    {
        teller++;
        if (teller > 1 && teller < 3)
        {
            Tween poezieFade = poeziestuk.GetComponent<SpriteRenderer>().DOFade(0, 1);
        }
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
            if (hartVerschijnTeller <= hartOnderdelen.Count)
            {
                if (hartVerschijnTeller == hartOnderdelen.Count - 1)
                {
                    Debug.Log("HartFinale!");
                    StartCoroutine(hartFinale());
                }
                else
                {
                    StartCoroutine(hartOntwikkelRoutine());
                }
            }
        }
    }

    IEnumerator hartOntwikkelRoutine()
    {
        hartOntwikkelBezig = true;
        if (hartVerschijnTeller > 1)
        {
            for (int i = 0; i < hartOnderdelen.Count; i++)
            {
                if (i == hartVerschijnTeller)
                {
                    continue;
                }
                else
                {
                    hartOnderdelen[i].SetActive(false);
                }
            }
            hartOnderdelen[hartVerschijnTeller].SetActive(true);
            yield return new WaitForSeconds(1f);
        }
        else
        {
            hartOnderdelen[hartVerschijnTeller].SetActive(true);
            hartOnderdelen[hartVerschijnTeller].transform.position = midden.position;
            Tween beweeg = hartOnderdelen[hartVerschijnTeller].transform.DOMove(hartOnderdelenPlekken[hartVerschijnTeller].position, 1f);
            yield return beweeg.WaitForCompletion();
        }

        hartVerschijnTeller++;
        hartOntwikkelBezig = false;
    }

    IEnumerator hartFinale()
    {
        hartOnderdelen[hartVerschijnTeller - 1].SetActive(false);
        hartOnderdelen[hartVerschijnTeller].SetActive(true);
        yield return new WaitForSeconds(2);
        owner.SwitchState(typeof(LenteBloemPlaatsStaat)); 
    }

    public override void OnExit()
    {

    }
}