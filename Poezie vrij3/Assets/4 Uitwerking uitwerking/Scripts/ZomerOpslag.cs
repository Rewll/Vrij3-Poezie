using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomerOpslag : MonoBehaviour
{
    public GameObject speler1;
    public GameObject speler2;
    [Space]
    public List<GameObject> knopIndicatoren1 = new List<GameObject>();
    public List<GameObject> knopIndicatoren2 = new List<GameObject>();

    public bool spelerDruktKnoppenInCheck(List<KeyCode> knoppenLijst)
    {
        foreach (KeyCode knop in knoppenLijst)
        {
            if (!Input.GetKey(knop))
            {
                return false;
            }
        }
        return true;
    }

    public void knopIndicatorsUitZetten()
    {
        foreach (GameObject knopIndicator in knopIndicatoren1)
        {
            knopIndicator.SetActive(false);
        }
        foreach (GameObject knopIndicator in knopIndicatoren2)
        {
            knopIndicator.SetActive(false);
        }
    }

    public void knopIndicatoren1Init(List<KeyCode> knopLijst)
    {
        foreach (GameObject indicator in knopIndicatoren1)
        {
            indicator.SetActive(false);
        }

        for (int i = 0; i < knopLijst.Count; i++)
        {
            knopIndicatoren1[i].GetComponent<IndicatorOpslag>().knop = knopLijst[i];
            knopIndicatoren1[i].GetComponent<IndicatorOpslag>().indicatorInstel();
            knopIndicatoren1[i].SetActive(true);
        }
    }

    public void knopIndicatoren2Init(List<KeyCode> knopLijst)
    {
        foreach (GameObject indicator in knopIndicatoren2)
        {
            indicator.SetActive(false);
        }

        for (int i = 0; i < knopLijst.Count; i++)
        {
            knopIndicatoren2[i].GetComponent<IndicatorOpslag>().knop = knopLijst[i];
            knopIndicatoren2[i].GetComponent<IndicatorOpslag>().indicatorInstel();
            knopIndicatoren2[i].SetActive(true);
        }
    }
}
