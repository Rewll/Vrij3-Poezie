using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class HerfstBeginStaat : HerfstBasisStaat
{
    HerfstRegelaar herfstRegelRef;

    private void Start()
    {
        DOTween.SetTweensCapacity(2000, 100);
        herfstRegelRef = GetComponent<HerfstRegelaar>();
        GetComponent<HerfstAgent>().huidigeStaat = HerfstAgent.herfstStaten.HerfstStartStaat;
        herfstRegelRef.anjerAnimatieRegelaar.animatieStart();
        herfstRegelRef.narcisAnimatieRegelaar.animatieStart();
        Tween fadeTween = herfstRegelRef.fadeVlak.DOFade(1, 0.000001f);
    }

    public override void OnEnter()
    {
        StartCoroutine(beginRoutine());
    }
    IEnumerator beginRoutine()
    {
        yield return new WaitForSeconds(2);
        Tween fadeTween = herfstRegelRef.fadeVlak.DOFade(0, 3f);
        yield return fadeTween.WaitForCompletion();
        owner.SwitchState(typeof(HerfstGroei1));
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        
    }
}