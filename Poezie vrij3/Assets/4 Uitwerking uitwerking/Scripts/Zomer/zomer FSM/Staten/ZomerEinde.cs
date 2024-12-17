using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ZomerEinde : ZomerBasisStaat
{
    ZomerOpslag regelaarOpslag;
    public Image fadeVlak;

    private void Awake()
    {
        regelaarOpslag = GetComponent<ZomerOpslag>();
    }

    public override void OnEnter()
    {
        GetComponent<ZomerAgent>().huidigeStaat = ZomerAgent.ZomerFsmStaten.ZomerEinde;
        StartCoroutine(eindeRoutine());
    }

    IEnumerator eindeRoutine()
    {
        regelaarOpslag.knopIndicatorsUitZetten(1);
        yield return new WaitForSeconds(1);
        Tween fadeUit = fadeVlak.DOFade(1, 5);
        yield return fadeUit.WaitForCompletion();
        //zomer afgelopen
        Debug.Log("Zomer afgelopen doei");
        SceneManager.LoadScene(2);
    }

    public override void OnUpdate()
    {

    }


    public override void OnExit()
    {

    }
}