using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
public enum bloemVersies { Speler1Bloem, Speler2Bloem};

public class HalfBloemLogica : MonoBehaviour
{
    public HerfstRegelaar herfstRegelRef;
    public Vector3 hartPlek;
    public Sprite speler1Bloem;
    public Sprite speler2Bloem;
    [Space]
    public GameObject canvas;
    public TMP_Text knopTekst;
    public SpriteRenderer SP;
    [Space]
    public bool vormGenomen;
    public bool alGevlogen;
    public bloemVersies bloemVersie;
    public KeyCode knopVanBloem;

    private void Start()
    {
        canvas.SetActive(false);
    }

    public bool magVliegen()
    {
        if (vormGenomen)
        {
            if (Input.GetKeyDown(knopVanBloem) && !alGevlogen)
            {
                alGevlogen = true;
                hartPlekBepalen();
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    void hartPlekBepalen()
    {
        if (bloemVersie == bloemVersies.Speler1Bloem)
        {
            hartPlek = herfstRegelRef.hartPlek1.position;
        }
        else if (bloemVersie == bloemVersies.Speler2Bloem)
        {
            hartPlek = herfstRegelRef.hartPlek2.position;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!vormGenomen)
        {
            if (collision.gameObject.tag == "Speler1")
            {
                bloemVersie = bloemVersies.Speler1Bloem;
                bloemNeemtVorm();
            }

            if (collision.gameObject.tag == "Speler2")
            {
                bloemVersie = bloemVersies.Speler2Bloem;
                bloemNeemtVorm();
            }
        }
    }

    void bloemNeemtVorm()
    {
        vormGenomen = true;
        if (bloemVersie == bloemVersies.Speler1Bloem)
        {
            SP.sprite = speler1Bloem;
            knopVanBloem = herfstRegelRef.speler1KnoppenLijst[Random.Range(0, herfstRegelRef.speler1KnoppenLijst.Count)];
            knopInit(knopVanBloem);
        }
        if (bloemVersie == bloemVersies.Speler2Bloem)
        {
            SP.sprite = speler2Bloem;
            knopVanBloem = herfstRegelRef.speler2KnoppenLijst[Random.Range(0, herfstRegelRef.speler2KnoppenLijst.Count)];
            knopInit(knopVanBloem);
        }
    }


    void knopInit(KeyCode knopInKwestie)
    {
        knopTekst.text = knopInKwestie.ToString();
        canvas.SetActive(true);
        //if (knopInKwestie == KeyCode.UpArrow)
        //{
        //    //pijltje logo
        //}
        //if (knopInKwestie == KeyCode.DownArrow)
        //{
        //    //pijltje logo
        //}
        //if (knopInKwestie == KeyCode.RightArrow)
        //{
        //    //pijltje logo
        //}
        //if (knopInKwestie == KeyCode.LeftArrow)
        //{
        //    //pijltje logo
        //}
        //else
        //{

        //}
    }
}