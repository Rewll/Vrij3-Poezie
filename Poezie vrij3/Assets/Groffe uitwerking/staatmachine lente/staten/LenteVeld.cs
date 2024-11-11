using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LenteVeld : BaseState2
{
    public GameObject speler1;
    public GameObject speler2;
    [Space]
    public Transform bestemmingSpeler1;
    public Transform bestemmingSpeler2;
    [Space]
    public GameObject cam;
    public override void OnEnter()
    {
        cam.SetActive(true);
        speler1.transform.position = bestemmingSpeler1.position;
        speler2.transform.position = bestemmingSpeler2.position;
    }
    public override void OnUpdate()
    {

    }

    public override void OnExit()
    {

    }
    public void lenteKlaar()
    {
        Debug.Log("Zomertijd!");
    }
}
