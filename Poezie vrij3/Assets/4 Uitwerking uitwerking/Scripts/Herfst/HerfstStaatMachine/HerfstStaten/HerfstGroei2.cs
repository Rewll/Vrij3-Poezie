using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class HerfstGroei2 : HerfstBasisStaat
{
    HerfstRegelaar herfstRegelRef;
    public GameObject huidigeHalfBloem;
    private HalfBloemLogica halfBloemLogicaRef;

    private void Start()
    {
        herfstRegelRef = GetComponent<HerfstRegelaar>();

        halfBloemLogicaRef = huidigeHalfBloem.GetComponent<HalfBloemLogica>();
        huidigeHalfBloem.SetActive(false);
    }

    public override void OnEnter()
    {
        GetComponent<HerfstAgent>().huidigeStaat = HerfstAgent.herfstStaten.HerfstGroei2;
        huidigeHalfBloem.transform.position = herfstRegelRef.bloemPlekBereken();
        huidigeHalfBloem.SetActive(true);
    }
    public override void OnUpdate()
    {
        if (halfBloemLogicaRef.magVliegen())
        {
            StartCoroutine(vliegRoutine());
        }
    }

    IEnumerator vliegRoutine()
    {
        Tween vliegTween = huidigeHalfBloem.transform.DOMove(halfBloemLogicaRef.hartPlek, 1f);
        yield return vliegTween.WaitForCompletion();
        huidigeHalfBloem.SetActive(false);
        herfstRegelRef.bloemResultaat(halfBloemLogicaRef.bloemVersie);
        herfstRegelRef.schudderRef.SchermSchudden();
        yield return new WaitUntil(() => herfstRegelRef.routineKlaar);
        herfstRegelRef.routineKlaar = false;
        owner.SwitchState(typeof(HerfstGroei3));
    }

    public override void OnExit()
    {

    }
}