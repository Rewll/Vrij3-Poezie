using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class TutorialStaat : BaseState
{
    public GameObject TutorialCamera;
    [Space]
    public InputActionReference speler1Input;
    public InputActionReference speler2Input;
    [Space]
    public TMP_Text looptekst1;
    public TMP_Text looptekst2;
    public TMP_Text plukTekst1;
    public TMP_Text pluktekst2;
    public GameObject bloem1;
    public GameObject bloem2;
    [Space]
    private bool gedrukt1 = false;
    private bool gedrukt2 = false;
    public int opraapTeller;
    [Space]
    public Image fadeVlak1;
    public Image fadeVlak2;

    public override void OnEnter()
    {
        TutorialCamera.SetActive(true);
        DOTween.SetTweensCapacity(2000, 100);

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
            //bloem1.DOFade(1, 2);
            bloem1.GetComponent<bloem>().faden();
            //Debug.Log("1");
        }


        if (speler2Input.action.ReadValue<Vector2>().y != 0 && !gedrukt2)
        {
            gedrukt2 = true;
            pluktekst2.DOFade(1, 2);
            //bloem2.DOFade(1, 2);
            bloem2.GetComponent<bloem>().faden();
            //Debug.Log("2");
        }




        if (GetComponent<GameManagerOpslag>().Speler1Opgeraapt)
        {
            //Debug.Log("Speler 1 opgeraapt");
            opraapTeller++;
            GetComponent<GameManagerOpslag>().Speler1Opgeraapt = false;
            fadeVlak1.DOFade(1, 2);
        }
        if (GetComponent<GameManagerOpslag>().Speler2Opgeraapt)
        {
            //Debug.Log("Speler 2 opgeraapt");
            opraapTeller++;
            GetComponent<GameManagerOpslag>().Speler2Opgeraapt = false;
            fadeVlak2.DOFade(1, 2);
        }
        int tmp = DOTween.TotalActiveTweens();
        if (opraapTeller >=2 && tmp == 0)
        {
            //Debug.Log("De wereld draait doorrrrrrrrrrrrrrrr");
            opraapTeller = 0;
            owner.SwitchState(typeof(Level1Staat));
        }

        //Als lopen: pluk tekst verschijn
        //Als speler plukt: fade zwart
        //Als Beide spelers geplukt hebben: naar volgende staat
    }

    public override void OnExit()
    {
        //Camerauit
        TutorialCamera.SetActive(false);
    }
}