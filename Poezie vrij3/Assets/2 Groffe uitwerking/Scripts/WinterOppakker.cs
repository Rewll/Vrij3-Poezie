using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterOppakker : MonoBehaviour
{
    public KeyCode opraapKnop;
    public GameObject tutorialtext;
    //public GameObject stukjeInHand;
    public bool handGevuld;
    public string OppakTag;
    [Space]
    public winterBloem bloemPak;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == OppakTag)
        {
            if (Input.GetKey(opraapKnop) && !handGevuld)
            {
                //stukjeInHand = collision.gameObject;
                tutorialtext.SetActive(false);
                collision.transform.parent = transform;
                handGevuld = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<winterBloemLogica>() && handGevuld)
        {
            if (bloemPak == collision.gameObject.GetComponent<winterBloemLogica>().bloemVariant)
            {
                leegHand();
                collision.gameObject.GetComponent<winterBloemLogica>().volgendePad();
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