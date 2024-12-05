using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Botsing : MonoBehaviour
{
    public UnityEvent alsBots;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            //Debug.Log("Bots!");
            alsBots.Invoke();
        }
    }
}