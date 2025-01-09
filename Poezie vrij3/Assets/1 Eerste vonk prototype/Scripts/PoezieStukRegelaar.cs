using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class PoezieStukRegelaar : MonoBehaviour
{
    public SpriteRenderer stukjePoezie;
    public bool klaar;
    //public UnityEvent poezieInloop;
    private void Start()
    {
        stukjePoezie.DOFade(0, 0.01f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<bloemOpraap>() && !klaar)
        {
            //poezieInloop.Invoke();
            stukjePoezie.DOFade(1, 3);
            klaar = true;
        }
    }
}