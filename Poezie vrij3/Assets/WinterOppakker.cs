using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterOppakker : MonoBehaviour
{
    public KeyCode opraapKnop;
    //public GameObject stukjeInHand;
    public bool handGevuld;
    public string OppakTag;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == OppakTag)
        {
            if (Input.GetKey(opraapKnop) && !handGevuld)
            {
                //stukjeInHand = collision.gameObject;
                collision.transform.parent = transform;
                handGevuld = true;
            }
        }
    }
    private void Update()
    {
        if (handGevuld && Input.GetKey(opraapKnop))
        {
            Debug.Log("hoi");
            //leegHand();
        }
    }
    public void leegHand()
    {
        transform.GetChild(0).parent = null;
        handGevuld = false;
    }
}
