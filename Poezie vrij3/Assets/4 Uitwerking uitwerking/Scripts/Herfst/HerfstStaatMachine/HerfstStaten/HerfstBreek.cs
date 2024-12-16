using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;


public class HerfstBreek : HerfstBasisStaat
{
    HerfstRegelaar herfstRegelRef;

    public GameObject oppakBloem1;
    public GameObject oppakBloem2;
    [Space]
    public Transform vliegPlek1;
    public Transform vliegPlek2;
    public int oppakTeller;

    public override void OnEnter()
    {
        herfstRegelRef = GetComponent<HerfstRegelaar>();

        //tekst verschijnen van hoi pak je bloem
        oppakBloem1.transform.DOMove(vliegPlek1.position, .75f);
        oppakBloem2.transform.DOMove(vliegPlek2.position, .75f);
        oppakBloem1.GetComponent<CircleCollider2D>().enabled = true;
        oppakBloem2.GetComponent<CircleCollider2D>().enabled = true;

    }

    public override void OnUpdate()
    {
        //bloem oppak logica
        if (oppakTeller == 2)
        {
            Debug.Log("BOE");
            StartCoroutine(eindeRoutine());
        }

    }

    IEnumerator eindeRoutine()
    {
        yield return new WaitForSeconds(1);
        Tween fadeTween = herfstRegelRef.fadeVlak.DOFade(1, 4f);
        yield return fadeTween.WaitForCompletion();
        yield return new WaitForSeconds(1);
        Debug.Log("Volgende bitch");
    }

    public override void OnExit()
    {

    }

    public void oppaktellerOmhoog()
    {
        oppakTeller++;
    }
}