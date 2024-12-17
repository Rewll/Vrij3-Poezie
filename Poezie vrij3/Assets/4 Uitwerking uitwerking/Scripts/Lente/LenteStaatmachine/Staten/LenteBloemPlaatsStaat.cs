using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LenteBloemPlaatsStaat : LenteBasisStaat
{
    GameManagerOpslag GO;

    public Transform speler1StartPlek;
    public Transform speler2StartPlek;
    [Space]
    public GameObject hart;
    public GameObject bloemPlaatsTekst;
    public Animator hartAnim;
    public Transform hartPlek;
    public GameObject hartMetKleur;
    public GameObject laatsteZonderKleur;
    public GameObject bloemenParent;
    [Space]
    public UnityEvent bloemSmeltNaar1;
    public override void OnEnter()
    {
        GO = GetComponent<GameManagerOpslag>();
        //GO.verplaatsSpelers(speler1StartPlek.position, speler2StartPlek.position);
        OverigeBloemenUitZetten(bloemenParent);
        hartPlek.gameObject.SetActive(true);
        bloemPlaatsTekst.SetActive(true);
        hart.transform.DOMove(hartPlek.position, 1);
        //Spelers bloemen worden 1 bloem
        bloemSmeltNaar1.Invoke();
    }

    public override void OnUpdate()
    {
        
    }

    public override void OnExit()
    {
        
    }

    public void machineStart()
    {
        StartCoroutine(machineStartRoutine());
    }

    IEnumerator machineStartRoutine()
    {
        yield return new WaitForSeconds(1f);
        laatsteZonderKleur.SetActive(false);
        hartMetKleur.SetActive(true);
        yield return new WaitForSeconds(1f);
        hartAnim.SetBool("HartMagBewegen", true);
        yield return new WaitForSeconds(5f);
        Debug.Log("Volgende scene !");
        SceneManager.LoadScene(1);
    }

    public void OverigeBloemenUitZetten(GameObject parent)
    {
        //Debug.Log(transform.childCount);
        int i = 0;

        //Array to hold all child obj
        GameObject[] allChildren = new GameObject[parent.transform.childCount];

        //Find all child obj and store to that array
        foreach (Transform child in parent.transform)
        {
            allChildren[i] = child.gameObject;
            i += 1;
        }

        //Now destroy them
        foreach (GameObject child in allChildren)
        {
            child.SetActive(false);
        }

        Debug.Log(parent.transform.childCount);
    }
}