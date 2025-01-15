using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using UnityEngine.UI;

public class poezieregelaarLiefdeScene : MonoBehaviour
{
    public Image fadeVlak;
    private void Start()
    {
        fadeVlak.DOFade(1, 0.001f);
        StartCoroutine(beginScene());
    }

    IEnumerator beginScene()
    {
        yield return new WaitForSeconds(1f);
        Tween fadeTween = fadeVlak.DOFade(0, 3);
    }
}
