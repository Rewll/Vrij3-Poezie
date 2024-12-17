using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class HerfstBreek : HerfstBasisStaat
{
    HerfstRegelaar herfstRegelRef;

    public GameObject oppakBloem1;
    public GameObject oppakBloem2;
    [Space]
    public TMP_Text oppakTekst;
    [Space]
    public Transform vliegPlek1;
    public Transform vliegPlek2;
    public int oppakTeller;

    private void Start()
    {
        Debug.Log("HOI");
        oppakTekst.DOFade(0, 0.0001f);
    }

    public override void OnEnter()
    {
        herfstRegelRef = GetComponent<HerfstRegelaar>();

        //tekst verschijnen van hoi pak je bloem
        StartCoroutine(beginRoutine());
    }

    IEnumerator beginRoutine()
    {
        oppakBloem1.transform.DOMove(vliegPlek1.position, .75f);
        Tween beweegTween = oppakBloem2.transform.DOMove(vliegPlek2.position, .75f);
        yield return beweegTween.WaitForCompletion();
        yield return new WaitForSeconds(1f);
        oppakTekst.DOFade(1, 1f);
        oppakBloem1.GetComponent<CircleCollider2D>().enabled = true;
        oppakBloem2.GetComponent<CircleCollider2D>().enabled = true;
    }

    public override void OnUpdate()
    {
        //bloem oppak logica
        if (oppakTeller == 2)
        {
            oppakTeller = 0;
            //Debug.Log("BOE");
            StartCoroutine(eindeRoutine());
        }

    }

    IEnumerator eindeRoutine()
    {
        yield return new WaitForSeconds(1);
        Tween fadeTween = herfstRegelRef.fadeVlak.DOFade(1, 4f);
        yield return fadeTween.WaitForCompletion();
        yield return new WaitForSeconds(1);
        //Debug.Log("Volgende bitch");
        SceneManager.LoadScene(3);
    }

    public override void OnExit()
    {

    }

    public void oppaktellerOmhoog()
    {
        oppakTeller++;
    }
}