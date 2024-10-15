using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum bloemVarianten
{
    Rood,
    Geel,
    Blauw
}
public class bloem : MonoBehaviour
{
    public KeyCode bloemKnop = KeyCode.G;
    public bloemVarianten bloemVariant;
    public TMP_Text knopTekst;
    public SpriteRenderer SR;
    public GameObject canvas;

    private void Start()
    {
        tekstKnopSet();
        bloemSpriteSet();
        canvas.GetComponent<Canvas>().worldCamera = Camera.main;
        canvas.GetComponent<Canvas>().sortingLayerName = "Bloem";
    }
    public void tekstKnopSet()
    {
        knopTekst.text = bloemKnop.ToString();
    }

    public void bloemSpriteSet()
    {
        switch (bloemVariant)
        {
            case bloemVarianten.Rood:
                SR.color = Color.red;
                break;
            case bloemVarianten.Geel:
                SR.color = Color.yellow;
                break;
            case bloemVarianten.Blauw:
                SR.color = Color.blue;
                break;
        }
    }

    public void opgeraapt()
    {
        Debug.Log(bloemVariant.ToString() + "Kleurige bloem met knop: " + bloemKnop.ToString() + " is opgeraapt");
        canvas.SetActive(false);
        GetComponent<CircleCollider2D>().enabled = false;
    }


}