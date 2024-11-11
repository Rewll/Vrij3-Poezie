using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botser : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<padOpraapScript>())
        {
            if (collision.gameObject.GetComponent<padOpraapScript>().handGevuld)
            {
                Debug.Log("pad bouwen!");
            }
            else
            {
                Debug.Log("Bots!");
            }
        }
    }
}
