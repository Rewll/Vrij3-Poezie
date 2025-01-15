using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.Events;

public enum bloemVarianten
{
    Bloem1,
    Bloem2,
    Bloem3,
    Bloem4
}
public class bloem : MonoBehaviour
{
    public KeyCode bloemKnop;
    public bloemVarianten bloemVariant;
    public TMP_Text knopTekst;
    public SpriteRenderer SR;
    public GameObject canvas;
    [Space]
    public bool verstoppen;
    public bool isOpgeraapt;
    [Space]
    public UnityEvent onOpraap;

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
        if (bloemKnop == KeyCode.Keypad7)
        {
            knopTekst.text = "Num\n7";
        }
        else if (bloemKnop == KeyCode.PageDown)
        {
            knopTekst.text = "Page \n Down";
        }
        else if (bloemKnop == KeyCode.Semicolon)
        {
            knopTekst.text = ";";
        }
        else if (bloemKnop == KeyCode.Slash)
        {
            knopTekst.text = "?";
        }
        else if (bloemKnop == KeyCode.Period)
        {
            knopTekst.text = "> \n .";
        }
        else if (bloemKnop == KeyCode.RightShift)
        {
            knopTekst.text = " R\nShift";
        }
        else if (bloemKnop == KeyCode.RightControl)
        {
            knopTekst.text = " R \n Control";
        }
        else
        {
            knopTekst.text = bloemKnop.ToString();
        }
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
        isOpgeraapt = true;
        //Debug.Log(bloemVariant.ToString() + "Kleurige bloem met knop: " + bloemKnop.ToString() + " is opgeraapt");
        canvas.SetActive(false);
        GetComponent<CircleCollider2D>().enabled = false;
    }

    public void faden()
    {
        knopTekst.DOFade(1, 2);
        SR.DOFade(1, 2);
    }

    public void uitFaden(float fadeTijd)
    {
        knopTekst.DOFade(0, fadeTijd);
        SR.DOFade(0, fadeTijd);
    }
}