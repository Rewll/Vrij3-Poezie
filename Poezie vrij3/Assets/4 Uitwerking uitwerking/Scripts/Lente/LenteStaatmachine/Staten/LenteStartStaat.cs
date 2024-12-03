using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class LenteStartStaat : LenteBasisStaat
{
    public GameObject Kamera;
    [Space]
    public InputActionReference speler1Input;
    public InputActionReference speler2Input;
    [Space]
    public TMP_Text looptekst1;
    public TMP_Text looptekst2;
    [Space]
    public TMP_Text plukTekst1;
    public TMP_Text pluktekst2;
    [Space]
    public GameObject bloem1;
    public GameObject bloem2;
    [Space]
    private bool gedrukt1 = false;
    private bool gedrukt2 = false;
    public int opraapTeller;
    [Space]
    public Image fadeVlak1;
    public Image fadeVlak2;

    private void OnEnable()
    {

    }

    public override void OnEnter()
    {
        DOTween.SetTweensCapacity(2000, 100);
        Tween fade1 = fadeVlak1.DOFade(1, 0.0001f);
        Tween fade2 = fadeVlak2.DOFade(1, 0.0001f);
        Kamera.SetActive(true);
        StartCoroutine(startRoutine());
    }

    IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(2f);
        Tween fade1 = fadeVlak1.DOFade(0, 2);
        Tween fade2 = fadeVlak2.DOFade(0, 2);
        yield return fade1.WaitForCompletion();
        yield return new WaitForSeconds(.5f);
        looptekst1.DOFade(1, 2);
        looptekst2.DOFade(1, 2);
    }

    public override void OnUpdate()
    {
        //Debug.Log("tweens = "+ DOTween.TotalActiveTweens());
        if (speler1Input.action.ReadValue<Vector2>().y != 0 && !gedrukt1)
        {
            gedrukt1 = true;
            plukTekst1.DOFade(1, 2);
            bloem1.GetComponent<bloem>().faden();
            //Debug.Log("1");
        }


        if (speler2Input.action.ReadValue<Vector2>().y != 0 && !gedrukt2)
        {
            gedrukt2 = true;
            pluktekst2.DOFade(1, 2);
            bloem2.GetComponent<bloem>().faden();
            //Debug.Log("2");
        }
    }

    public void naOprapen1()
    {
        Tween fade1 = fadeVlak1.DOFade(1, 2);
        opraapTeller++;
        if (opraapTeller >= 2)
        {
            Debug.Log("Volgende !");
            VolgendeStukkie();
        }
    }

    public void naOprapen2()
    {
        Tween fade2 = fadeVlak2.DOFade(1, 2);
        opraapTeller++;
        if (opraapTeller >= 2)
        {
            Debug.Log("Volgende !");
            VolgendeStukkie();
        }
    }

    public void VolgendeStukkie()
    {
        owner.SwitchState(typeof(LenteStuk1Staat));
    }

    public override void OnExit()
    {
        Kamera.SetActive(false);
    }
}