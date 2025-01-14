using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class WederliefdeBloem : WederLiefdeBasisStaat
{
    WederliefdeRegelaar regelaarRef;
    public TMP_Text oppakTekst;
    public GameObject narcis;
    public GameObject anjer;
    [Space]
    public AnimatieRegelBedoeling animRegelRef;
    [Space]
    public TMP_Text instructieTekst;
    [Space]
    public GameObject heelHartStilStaandParent;
    public GameObject heelHartStilStaand;
    public GameObject hartBewegend;
    public GameObject bloemBewegend;


    private void Start()
    {
        regelaarRef = GetComponent<WederliefdeRegelaar>();
        oppakTekst.DOFade(0, 0.00001f);

        narcis.transform.GetChild(0).GetComponent<SpriteRenderer>().DOFade(0, 0.00001f);
        anjer.transform.GetChild(0).GetComponent<SpriteRenderer>().DOFade(0, 0.00001f);
        heelHartStilStaandParent.GetComponent<BoxCollider2D>().enabled = false;
        hartBewegend.GetComponent<SpriteRenderer>().DOFade(0, 0.00001f);

        bloemBewegend.GetComponent<SpriteRenderer>().DOFade(0, 0.00001f);
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
        heelHartStilStaandParent.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void hartBewegenEinde()
    {
        StartCoroutine(hartBewegen());
    }

    IEnumerator hartBewegen()
    {
        instructieTekst.DOFade(0, 0.5f);
        animRegelRef.WederCrossFade(heelHartStilStaand, hartBewegend, bloemBewegend, 1f);
        yield return new WaitForSeconds(15f);
        Tween fadeTween = regelaarRef.fadeVlak.DOFade(1, 2);
        yield return fadeTween.WaitForCompletion();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(11);
    }

    public override void OnUpdate()
    {
        
    }

    public override void OnExit()
    {
        
    }
}