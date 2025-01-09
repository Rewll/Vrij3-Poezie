using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.Events;

public class WederliefdeRegelaar : MonoBehaviour
{
    public Image fadeVlak;
    [Space]
    public GameObject speler1;
    public GameObject speler2;
    [Space]
    public GameObject knopIndicator1;
    public GameObject knopIndicator2;
    [Space]
    [Space]
    [Header("Stukken hart")]
    public GameObject stuk1;
    public GameObject stuk1A;
    public GameObject stuk1B;
    [Space]
    public GameObject stuk2;
    public GameObject stuk2A;
    public GameObject stuk2B;
    [Space]
    public GameObject stuk3;
    public GameObject stuk3A;
    public GameObject stuk3B;
    [Space]
    public GameObject stuk4;
    public GameObject stuk4A;
    public GameObject stuk4B;
    [Space]
    [Space]
    [Header("Stukken Plekken")]
    public Transform plek1A;
    public Transform plek1B;
    [Space]
    public Transform plek2A;
    public Transform plek2B;
    [Space]
    public Transform plek3A;
    public Transform plek3B;
    [Space]
    public Transform plek4A;
    public Transform plek4B;
    [Space]
    public UnityEvent alsSuccesVolleBots;
    [Space]
    public List<MonoBehaviour> metaWeetJeDitNogNietVergetenDus;


    public void spelersTerugSlag(float terugSlagHoeveelHeid)
    {
        speler1.GetComponent<SpelerBeweging>().beweegTerugBeetje(terugSlagHoeveelHeid);
        speler2.GetComponent<SpelerBeweging>().beweegTerugBeetje(terugSlagHoeveelHeid);
    }

    public void stukjesRepareer(GameObject stuk1, 
                                GameObject stuk2,
                                Transform stuk1Plek,
                                Transform stuk2Plek,
                                float beweegSnelheid)
    {
        Tween beweeg1Tween = stuk1.transform.DOMove(stuk1Plek.position, beweegSnelheid);
        Tween beweeg2Tween = stuk2.transform.DOMove(stuk2Plek.position, beweegSnelheid);
    }

    public void knopIndicatorsUitZetten(float fadeSnelHeid)
    {
        knopIndicator1.GetComponent<IndicatorOpslag>().fadeUitMethod(fadeSnelHeid);
        knopIndicator2.GetComponent<IndicatorOpslag>().fadeUitMethod(fadeSnelHeid);
    }

    public void knopIndicatorsInFaden(float fadeSnelHeid)
    {
        knopIndicator1.GetComponent<IndicatorOpslag>().fadeInMethod(fadeSnelHeid);
        knopIndicator2.GetComponent<IndicatorOpslag>().fadeInMethod(fadeSnelHeid);
    }

    public void knopIndicator1Init(KeyCode knop)
    {
        knopIndicator1.GetComponent<IndicatorOpslag>().knop = knop;
        knopIndicator1.GetComponent<IndicatorOpslag>().indicatorInstel();
        knopIndicator1.GetComponent<IndicatorOpslag>().fadeInMethod(1);
    }

    public void knopIndicator2Init(KeyCode knop)
    {
        knopIndicator2.GetComponent<IndicatorOpslag>().knop = knop;
        knopIndicator2.GetComponent<IndicatorOpslag>().indicatorInstel();
        knopIndicator2.GetComponent<IndicatorOpslag>().fadeInMethod(1);
    }
    public float lerpUitrekenaar(Transform pos1, Transform pos2, float maxAfstand)
    {
        float afstand = (Vector2.Distance(pos1.position,
                                          pos2.position));
        float afstand2 = Mathf.Min(afstand, maxAfstand);

        return (afstand2 / maxAfstand);
    }

    public Vector2 lerper(Vector2 begin, Vector2 bestemming, float maxAfstand)
    {
        return Vector2.Lerp(begin, bestemming, lerpUitrekenaar(speler1.transform, speler2.transform, maxAfstand));
    }
}