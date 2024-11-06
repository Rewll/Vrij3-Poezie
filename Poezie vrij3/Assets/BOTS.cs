using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOTS : MonoBehaviour
{
    public SpriteRenderer achtergrond;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            achtergrond.color = Color.cyan;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            achtergrond.color = Color.green;
        }
    }
}
