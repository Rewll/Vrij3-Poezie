using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class ZomerStartStaat : ZomerBasisStaat
{
    ZomerOpslag regelaarOpslag;
    public Image fadeVlak;

    private void Awake()
    {
        regelaarOpslag = GetComponent<ZomerOpslag>();
    }

    public override void OnEnter()
    {
        GetComponent<ZomerAgent>().huidigeStaat = ZomerAgent.ZomerFsmStaten.ZomerStartStaat;
        regelaarOpslag.knopIndicatorsUitZetten(0.001f);
        regelaarOpslag.animatieRegelRef.animatieStart();

        StartCoroutine(beginCoroutine());
    }
    IEnumerator beginCoroutine()
    {
        fadeVlak.DOFade(1, 0.00001f);
        yield return new WaitForSeconds(2);
        fadeVlak.DOFade(0, 3);
        yield return new WaitForSeconds(3);
        owner.SwitchState(typeof(ZomerLevel1));
    }

    public override void OnUpdate()
    {
        
    }
    public override void OnExit()
    {
        
    }
}