using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BOTS : MonoBehaviour
{
    public SpriteRenderer bloemetjs;
    private void Start()
    {
        bloemetjs.DOFade(0, 0.001f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            bloemetjs.DOFade(1, 1);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            bloemetjs.DOFade(0, 1);
        }
    }
}
