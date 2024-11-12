using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class padStukLogica : MonoBehaviour
{
    public Transform beweegBestemming;
    public bool klaar;
    public bool laatsePad;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<herfstBotser>())
        {
            if (!klaar && collision.gameObject.GetComponent<herfstBotser>().botsende)
            {
                klaar = true;
                Debug.Log(gameObject.name + " Breek af nu");
                breekAf();
                collision.gameObject.GetComponent<herfstBotser>().breekTeller++;
            }
        }
    }

    void breekAf()
    {
        //transform.position = beweegBestemming.position;
        transform.DOMove(beweegBestemming.position, .5f).SetEase(Ease.InQuint);
        if (laatsePad)
        {
            StartCoroutine(eindeRoutine());
        }
    }

    IEnumerator eindeRoutine()
    {
        yield return new WaitForSeconds(6f);
        Debug.Log("volgende!");
    }
}