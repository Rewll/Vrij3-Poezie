using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winterStukOppak : MonoBehaviour
{
    public KeyCode opraapKnop;
    public KeyCode bloemPlaatsKnop;
    public stukjeSpeler speler;
    public winterBloem bloemSoortSpeler;
    [Space]
    public GameObject tutorialTekst1;
    public GameObject tutorialTekst2;
    [Space]
    public GameObject stukInHanden;
    public bool handGevuld;
    [Space]
    public bool stukjesCompleet;
    [Space]
    public GameObject bloemInHanden;
    public bool bloemGeplaatst;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!stukjesCompleet)
        {
            if (!handGevuld)
            {
                if (collision.GetComponent<winterStukken>())
                {
                    if (collision.GetComponent<winterStukken>().voorWieStukIs == speler)
                    {
                        if (Input.GetKey(opraapKnop))
                        {
                            stukInHanden = collision.gameObject;
                            stukInHanden.transform.parent = transform;                            
                            handGevuld = true;
                        }
                    }
                }
            }
            else if (handGevuld)
            {
                if (collision.gameObject.GetComponent<winterBloemen>())
                {
                    if (bloemSoortSpeler == collision.gameObject.GetComponent<winterBloemen>().bloemSoort)
                    {
                        handGevuld = false;
                        collision.gameObject.GetComponent<winterBloemen>().plaatsStukje(stukInHanden);
                        tutorialTekst1.SetActive(false);
                        stukInHanden = null;
                    }
                }
            }
        }
        else if (stukjesCompleet && !bloemGeplaatst)
        {
            if (collision.gameObject.GetComponent<winterBloemen>())
            {
                if (Input.GetKey(bloemPlaatsKnop))
                {
                    if (bloemSoortSpeler == collision.gameObject.GetComponent<winterBloemen>().bloemSoort)
                    {
                        bloemGeplaatst = true;
                        collision.gameObject.GetComponent<winterBloemen>().plaatsBloem(bloemInHanden);
                    }
                }
            }
        }
    }

    public void compleetOpTrue()
    {
        stukjesCompleet = true;
        tutorialTekst1.SetActive(false);
        tutorialTekst2.SetActive(true);
    }
}