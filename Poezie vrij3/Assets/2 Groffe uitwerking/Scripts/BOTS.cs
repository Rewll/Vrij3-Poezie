using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class BOTS : MonoBehaviour
{
    public SpriteRenderer bloemetjs;
    public UnityEvent bots;

    private void Start()
    {
        //bloemetjs.DOFade(0, 0.001f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            bots.Invoke();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            
        }
    }
}
