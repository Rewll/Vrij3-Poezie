using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winterStukOppak : MonoBehaviour
{
    public KeyCode opraapKnop;
    public stukjeSpeler speler;
    public winterBloem bloemSoortSpeler;
    [Space]
    public GameObject stukInHanden;
    public bool handGevuld;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<winterStukken>().voorWieStukIs == speler)
        {
            if (Input.GetKey(opraapKnop) && !handGevuld)
            {
                stukInHanden = collision.gameObject;
                stukInHanden.transform.parent = transform;
                handGevuld = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<winterBloemen>() && handGevuld)
        {
            if (bloemSoortSpeler == collision.gameObject.GetComponent<winterBloemen>().bloemSoort)
            {
                handGevuld = false;
                collision.gameObject.GetComponent<winterBloemen>().plaatsStukje(stukInHanden);
                stukInHanden = null;
            }
        }
    }
    public void leegHand()
    {
        if (transform.GetChild(0))
        {
            Destroy(transform.GetChild(0).gameObject);
        }
        handGevuld = false;
    }
}