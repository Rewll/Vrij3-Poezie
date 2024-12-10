using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerOpslag : MonoBehaviour
{
    public GameObject speler1;
    public GameObject speler2;
    [Space]
    public bool Speler1Opgeraapt;
    public bool Speler2Opgeraapt;

    public void verplaatsSpelers(Vector3 bestemmingSpeler1, Vector3 bestemmingSpeler2)
    {
        speler1.transform.position = bestemmingSpeler1;
        speler2.transform.position = bestemmingSpeler2;
    }

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

    public void opraap1OpTrue()
    {
        Speler1Opgeraapt = true;
    }

    public void opraap2OpTrue()
    {
        Speler2Opgeraapt = true;
    }
}