using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;

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
    private bool gedrukt1;
    private bool gedrukt2;
    public override void OnEnter()
    {
        DOTween.SetTweensCapacity(2000, 100);
        //LoopTekst verschijn
        looptekst1.DOFade(1, 2);
        looptekst2.DOFade(1, 2);
    }

    public override void OnUpdate()
    {
        if (speler1Input.action.ReadValue<Vector2>().x >= 1 && !gedrukt1)
        {
            gedrukt2 = true;
            plukTekst1.DOFade(1, 2);
            bloem1.DOFade(1, 2);
            Debug.Log("1");
        }
        if (speler2Input.action.ReadValue<Vector2>().x >= 1 && !gedrukt2)
        {
            gedrukt2 = true;
            pluktekst2.DOFade(1, 2);
            bloem2.DOFade(1, 2);
            Debug.Log("2");
        }
        //Als lopen: pluk tekst verschijn
        //Als speler plukt: fade zwart
        //Als Beide spelers geplukt hebben: naar volgende staat
    }

    public override void OnExit()
    {
        //Camerauit
    }
}
