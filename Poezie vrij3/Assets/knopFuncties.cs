using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class knopFuncties : MonoBehaviour
{
    public SpriteRenderer fadeVlak;
    public TMP_Text tekst;
    public void startSpel()
    {
        StartCoroutine(startSpelRoutine());
    }
    IEnumerator startSpelRoutine()
    {
        Tween fadeTween = fadeVlak.DOFade(1, 2f);
        Tween fadeTween2 = tekst.DOFade(0, 2f);
        yield return fadeTween.WaitForCompletion();
        yield return fadeTween2.WaitForCompletion();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}