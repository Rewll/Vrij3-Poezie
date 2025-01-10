using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Botsing : MonoBehaviour
{
    public UnityEvent alsBots;
    public UnityEvent alsBotsVerlaat;
    //[Space]
    //public Vector2 midden;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            //Debug.Log("Bots!");
            //midden = transform.position - (transform.position - collision.transform.position) / 2;
            alsBots.Invoke();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            //Debug.Log("Bots!");
            alsBotsVerlaat.Invoke();
        }
    }
}