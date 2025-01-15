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
        kiesKnoppen();
    }

    void kiesKnoppen()
    {
        int random = Random.Range(0, 2);
        if (random == 0)
        {
            anjer.GetComponent<bloem>().bloemKnop = KeyCode.N;
            anjer.GetComponent<bloem>().tekstKnopSet();
            narcis.GetComponent<bloem>().bloemKnop = KeyCode.M;
            narcis.GetComponent<bloem>().tekstKnopSet();
        }
        else if (random == 1)
        {
            anjer.GetComponent<bloem>().bloemKnop = KeyCode.Y;
            anjer.GetComponent<bloem>().tekstKnopSet();
            narcis.GetComponent<bloem>().bloemKnop = KeyCode.U;
            narcis.GetComponent<bloem>().tekstKnopSet();
        }
        else
        {
            Debug.Log("Klopt niet, random is groter dan 1");
        }
    }
}