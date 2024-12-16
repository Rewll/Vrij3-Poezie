using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinterStartStaat : WinterBasisStaat
{
    public int bloemKlaarTeller;

    public override void OnEnter()
    {
        //fade in bedoeling
        //tutorialtekstbedoeling
    }

    public override void OnUpdate()
    {
        
    }

    public override void OnExit()
    {
        
    }

    void tellerRegel()
    {
        bloemKlaarTeller++;
        if (bloemKlaarTeller >=2)
        {
            Debug.Log("Alles is geplaatst");
            //stukjes laten vallen
        }
    }
}