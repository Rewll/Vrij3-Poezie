using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class HerfstRegelaar : MonoBehaviour
{
    public GameObject Speler1;
    public GameObject Speler2;
    [Space]
    public Transform terugVliegPlek1;
    public Transform terugVliegPlek2;
    [Space]
    public Transform maxBloemPlek;
    public Transform minBloemPlek;
    [Space]
    public GameObject hart;
    [Space]
    public List<KeyCode> speler1KnoppenLijst = new List<KeyCode>();
    public List<KeyCode> speler2KnoppenLijst = new List<KeyCode>();
    [Space]
    public Transform hartPlek1;
    public Transform hartPlek2;
    [Space]
    public bool routineKlaar;
    
    public void SpelersTerugRecoil()
    {
        Speler1.transform.DOMove(terugVliegPlek1.position, .5f);
        Speler2.transform.DOMove(terugVliegPlek2.position, .5f);
    }

    public Vector3 bloemPlekBereken()
    {
        return new Vector3(Random.Range(minBloemPlek.position.x, maxBloemPlek.position.x),
                           Random.Range(minBloemPlek.position.y, maxBloemPlek.position.y));
    }

    public void bloemResultaat(bloemVersies bloemVersie)
    {
        if (bloemVersie == bloemVersies.Speler1Bloem)
        {
            StartCoroutine(resultaatRoutine(bloemVersies.Speler1Bloem));
        }
        else if (bloemVersie == bloemVersies.Speler2Bloem)
        {
            StartCoroutine(resultaatRoutine(bloemVersies.Speler2Bloem));
        }
    }

    IEnumerator resultaatRoutine(bloemVersies bloemVersie)
    {
        SpelersTerugRecoil();
        if (bloemVersie == bloemVersies.Speler1Bloem)
        {
            Debug.Log("Bloem 1 groei!");
        }
        else if (bloemVersie == bloemVersies.Speler2Bloem)
        {
            Debug.Log("Bloem 2 groei!");
        }
        //Hartanimatie vooruit
        yield return new WaitForSeconds(1);
        routineKlaar = true;
    }

}