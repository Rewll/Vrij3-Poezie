using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SamenBloemChecker : MonoBehaviour
{
    public bloemenSpawner spawnerRef;
    [Space]
    public GameObject anjer;
    public GameObject narcis;
    [Space]
    public UnityEvent beideGeplukt;
    public int plukTeller;

    public void plukTellen()
    {
        plukTeller++;
        if (plukTeller >= 2)
        {
            //beideGeplukt.Invoke();
            spawnerRef.nieuweBloem();
        }
    }

    public void PlaatsBloem(Vector2 anjerPlek, Vector2 narcisPlek)
    {
        anjer.transform.position = anjerPlek;
        narcis.transform.position = narcisPlek;
    }
}