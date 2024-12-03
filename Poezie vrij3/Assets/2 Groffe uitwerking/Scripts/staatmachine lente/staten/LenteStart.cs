using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LenteStart : BaseState2
{
    public int speler1PlukTeller;
    public int speler2PlukTeller;
    [Space]
    public GameObject cam;
    public override void OnEnter()
    {
        cam.SetActive(true);
    }
    public override void OnUpdate()
    {
        if (speler1PlukTeller >=3 && speler2PlukTeller >=3)
        {
            Debug.Log("volgendee");
            owner.SwitchState(typeof(LenteVeld));
        }
    }

    public override void OnExit()
    {
        cam.SetActive(false);   
    }

    public void teller1Plus()
    {
        speler1PlukTeller++;
    }

    public void teller2Plus()
    {
        speler2PlukTeller++;
    }
}