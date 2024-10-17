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
    public SpriteRenderer bloem1;
    public SpriteRenderer bloem2;
    [Space]
    private bool gedrukt1 = false;
    private bool gedrukt2 = false;
    public bool Speler1Opgeraapt;
    public bool Speler2Opgeraapt;
    public int opraapTeller;
    [Space]
    public Image fadeVlak1;
    public Image fadeVlak2;
    public override void OnEnter()
    {
        DOTween.SetTweensCapacity(2000, 100);
        //LoopTekst verschijn
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
            Debug.Log("1");
        }
        if (speler2Input.action.ReadValue<Vector2>().y != 0 && !gedrukt2)
        {
            gedrukt2 = true;
            pluktekst2.DOFade(1, 2);
            //bloem2.DOFade(1, 2);
            bloem2.GetComponent<bloem>().faden();
            Debug.Log("2");
        }

        if (Speler1Opgeraapt)
        {
            //Debug.Log("Speler 1 opgeraapt");
            opraapTeller++;
            Speler1Opgeraapt = false;
            fadeVlak1.DOFade(1, 2);
        }
        if (Speler2Opgeraapt)
        {
            //Debug.Log("Speler 2 opgeraapt");
            opraapTeller++;
            Speler2Opgeraapt = false;
            fadeVlak2.DOFade(1, 2);
        }
        int tmp = DOTween.TotalActiveTweens();
        if (opraapTeller >=2 && tmp == 0)
        {
            Debug.Log("De wereld draait doorrrrrrrrrrrrrrrr");
            opraapTeller = 0;
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

    public void opraap1OpTrue()
    {
        Speler1Opgeraapt = true;
    }

    public void opraap2OpTrue()
    {
        Speler2Opgeraapt = true;
    }
}