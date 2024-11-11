using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigjerheh : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<SpelerBeweging>())
        {
            Debug.Log("volgende scene!");
        }
    }
}
