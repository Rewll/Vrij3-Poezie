using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padOpraapScript : MonoBehaviour
{
    public KeyCode opraapKnop;
    public GameObject tutorialtekst;
    //public GameObject stukjeInHand;
    public bool handGevuld;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<padStukje>())
        {
            if (Input.GetKey(opraapKnop) && !handGevuld)
            {
                //stukjeInHand = collision.gameObject;
                tutorialtekst.SetActive(false);
                collision.transform.parent = transform;
                handGevuld = true;
            }
        }
    }

    public void leegHand()
    {
        Destroy(transform.GetChild(0).gameObject);
        handGevuld = false;
    }
}