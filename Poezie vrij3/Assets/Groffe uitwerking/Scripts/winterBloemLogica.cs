using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum winterBloem
{
    Rood,
    Geel
}
public class winterBloemLogica : MonoBehaviour
{
    public winterBloem bloemVariant;
    public winterRegelaar WR;
    [Space]
    public List<GameObject> alleenPadstukken = new List<GameObject>();
    public int padOnthulTeller;
    private void Start()
    {
        foreach (GameObject stuk in alleenPadstukken)
        {
            stuk.SetActive(false);
        }
    }
    public void volgendePad()
    {
        if (padOnthulTeller <= alleenPadstukken.Count)
        {
            alleenPadstukken[padOnthulTeller].SetActive(true);
            padOnthulTeller++;
        }
        if (padOnthulTeller >= alleenPadstukken.Count)
        {
            WR.spelerKlaarTeller++;
            WR.doorgaanCheck();
        }
    }
}