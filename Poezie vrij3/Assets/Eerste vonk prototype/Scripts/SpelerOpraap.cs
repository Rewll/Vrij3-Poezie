using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpelerOpraap : MonoBehaviour
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
                    collision.GetComponent<bloem>().opgeraapt();
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
}