using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class bloemOpraap : MonoBehaviour
{
    public bloemVarianten opraapVariant;
    public UnityEvent opraap;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<bloem>())
        {
            if (collision.GetComponent<bloem>().bloemVariant == opraapVariant)
            {
                if (Input.GetKey(collision.GetComponent<bloem>().bloemKnop))
                {
                    collision.GetComponent<bloem>().onOpraap.Invoke();
                    collision.transform.parent = transform;
                    opraap.Invoke();
                }
            }
        }
    }

    public void opraapLogica()
    {
        Debug.Log("Test");
    }

    public void bloemSmelt()
    {
        //Debug.Log(transform.childCount);
        if (transform.childCount > 1)
        {
            //Debug.Log(transform.childCount);
            int teller = 0;
            foreach (Transform kind in transform)
            {
                teller++;
                if (teller == 1)
                {
                    continue;
                }
                else
                {
                    Destroy(kind.gameObject);
                }
            }
        }
    }
}