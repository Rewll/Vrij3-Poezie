using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HartBotsing : MonoBehaviour
{
    public UnityEvent bots;
    public Transform midden;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            midden.position = transform.position - (transform.position - collision.transform.position) / 2;
            bots.Invoke();
        }
    }
}