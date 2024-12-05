using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class ZomerStartStaat : ZomerBasisStaat
{
    public Image fadeVlak;

    IEnumerator beginCoroutine()
    {
        fadeVlak.DOFade(1, 0.00001f);
        yield return new WaitForSeconds(2);
        fadeVlak.DOFade(0, 3);
    }

    public override void OnEnter()
    {
        StartCoroutine(beginCoroutine());
        GetComponent<ZomerAgent>().huidigeStaat = ZomerAgent.ZomerFsmStaten.ZomerStartStaat;
        owner.SwitchState(typeof(ZomerLevel1));
    }

    public override void OnUpdate()
    {
        
    }
    public override void OnExit()
    {
        
    }
}