using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public enum bloemVarianten
{
    Bloem1,
    Bloem2,
    Bloem3,
    Bloem4
}
public class bloem : MonoBehaviour
{
    public KeyCode bloemKnop = KeyCode.G;
    public bloemVarianten bloemVariant;
    public TMP_Text knopTekst;
    public SpriteRenderer SR;
    public GameObject canvas;
    [Space]
    public bool verstoppen;

    private void Start()
    {
        tekstKnopSet();
        bloemSpriteSet();
        canvas.GetComponent<Canvas>().worldCamera = Camera.main;
        canvas.GetComponent<Canvas>().sortingLayerName = "Bloem";

        if (verstoppen)
        {
            Color tmp = SR.color;
            tmp.a = 0f;
            SR.color = tmp;

            Color tmp2 = knopTekst.color;
            tmp2.a = 0f;
            knopTekst.color = tmp2;
        }
    }
    public void tekstKnopSet()
    {
        knopTekst.text = bloemKnop.ToString();
    }

    public void bloemSpriteSet()
    {
        switch (bloemVariant)
        {
            case bloemVarianten.Bloem1:
                //SR.color = Color.red;
                break;
            case bloemVarianten.Bloem2:
                //SR.color = Color.yellow;
                break;
            case bloemVarianten.Bloem3:
                //SR.color = Color.blue;
                break;
            case bloemVarianten.Bloem4:
                //SR.color = Color.blue;
                break;
        }
    }

    public void opgeraapt()
    {
        Debug.Log(bloemVariant.ToString() + "Kleurige bloem met knop: " + bloemKnop.ToString() + " is opgeraapt");
        canvas.SetActive(false);
        GetComponent<CircleCollider2D>().enabled = false;
    }

    public void faden()
    {
        knopTekst.DOFade(1, 2);
        SR.DOFade(1, 2);
    }
}