using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZomerBotsing : MonoBehaviour
{
    public UnityEvent bots;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            Debug.Log("Bots!");
            bots.Invoke();
        }
    }
}