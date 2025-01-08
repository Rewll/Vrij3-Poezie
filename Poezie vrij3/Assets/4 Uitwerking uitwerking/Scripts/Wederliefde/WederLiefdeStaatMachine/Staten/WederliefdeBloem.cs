using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class WederliefdeBloem : WederLiefdeBasisStaat
{
    public TMP_Text oppakTekst;
    public GameObject narcis;
    public GameObject anjer;
    [Space]
    public GameObject heelHartStilStaand;

    private void Start()
    {
        oppakTekst.DOFade(0, 0.00001f);
        narcis.transform.GetChild(0).GetComponent<SpriteRenderer>().DOFade(0, 0.00001f);
        anjer.transform.GetChild(0).GetComponent<SpriteRenderer>().DOFade(0, 0.00001f);
        heelHartStilStaand.GetComponent<BoxCollider2D>().enabled = false;
    }

    public override void OnEnter()
    {
        GetComponent<WederLiefdeAgent>().huidigeStaat = WederLiefdeAgent.WederLiefdeFSMStaten.WederliefdeBloem;
        
        StartCoroutine(startRoutine());
    }

    IEnumerator startRoutine()
    {
        Tween fadeTween = oppakTekst.DOFade(1, 1);
        yield return fadeTween.WaitForCompletion();
        narcis.transform.GetChild(0).GetComponent<SpriteRenderer>().DOFade(1, 1f);
        anjer.transform.GetChild(0).GetComponent<SpriteRenderer>().DOFade(1, 1f);
        heelHartStilStaand.GetComponent<BoxCollider2D>().enabled = true;

    }

    public override void OnUpdate()
    {
        
    }

    public override void OnExit()
    {
        
    }
}