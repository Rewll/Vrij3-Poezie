using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class LenteVeld : BaseState2
{
    public GameObject speler1;
    public GameObject speler2;
    [Space]
    public Transform bestemmingSpeler1;
    public Transform bestemmingSpeler2;
    [Space]
    public GameObject cam;
    [Space]
    public SpriteRenderer bloemtjs;
    public float afstandGrens;
    public bool spelersDichtbijGenoeg;
    [Space]
    public float maxAfstand;
    public float afstand;
    [Space]
    public List<GameObject> hartStukken = new List<GameObject>();
    public int hartVerschijnTeller;

    public override void OnEnter()
    {
        foreach (GameObject stuk in hartStukken)
        {
            stuk.SetActive(false);
        }

        DOTween.SetTweensCapacity(2000, 100);
        bloemtjs.color = new Color(bloemtjs.color.r, bloemtjs.color.g, bloemtjs.color.b, 0);
        cam.SetActive(true);
        speler1.transform.position = bestemmingSpeler1.position;
        speler2.transform.position = bestemmingSpeler2.position;
    }
    public override void OnUpdate()
    {
        afstand = Vector2.Distance(speler1.transform.position, speler2.transform.position);
        float afstand2 = Mathf.Min(Vector2.Distance(speler1.transform.position, speler2.transform.position), maxAfstand);
        bloemtjs.color = new Color(bloemtjs.color.r, bloemtjs.color.g, bloemtjs.color.b, 1 - (afstand2/maxAfstand));
    }

    public override void OnExit()
    {
        cam.SetActive(false);
    }

    public void hartOntwikkel() 
    {
        if (hartVerschijnTeller < hartStukken.Count)
        {
            hartStukken[hartVerschijnTeller].SetActive(true);
            hartVerschijnTeller++;
        }
        else if (hartVerschijnTeller >= hartStukken.Count)
        {
            owner.SwitchState(typeof(HartPlaatsFase));
        }
    }

    public void lenteKlaar()
    {
        //SceneManager.LoadScene(1);
    }
}
