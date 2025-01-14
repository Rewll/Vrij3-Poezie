using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;
using TMPro;

public class winterBloemen : MonoBehaviour
{
    public winterBloem bloemSoort;
    [Space]
    public UnityEvent alsStukjesCompleet;
    public UnityEvent alsMachineKlaar;
    [Space]
    public List<GameObject> geplaatsteStukjes = new List<GameObject>();
    public bool alleStukjesGeplaatst;
    public int stukjeTeller;
    [Space]
    public GameObject instructieTekstObject;
    public TMP_Text instructieTekst;
    public TMP_Text plaatsTekst;

    private void Start()
    {
        instructieTekst.DOFade(0, 0.0001f);
        plaatsTekst.DOFade(0, 0.0001f);

        foreach (GameObject stukje in geplaatsteStukjes)
        {
            stukje.SetActive(false);
            stukje.GetComponent<BoxCollider2D>().enabled = false;
            stukje.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }

    public void plaatsStukje(GameObject stukje)
    {
        if (!alleStukjesGeplaatst)
        {
            activeerStukje(stukje.GetComponent<winterStukken>().stukjeVariant);
            Destroy(stukje);
            stukjeTeller++;
            if (stukjeTeller == 1)
            {
                StartCoroutine(tekstUitFader());
            }
            if (stukjeTeller == 4)
            {
                alleStukjesGeplaatst = true;
                plaatsTekst.DOFade(1, 2f);
                alsStukjesCompleet.Invoke();
            }
        }

    }

    IEnumerator tekstUitFader()
    {
        Tween fadeTween = instructieTekst.DOFade(0, 1f);
        yield return fadeTween.WaitForCompletion();
        instructieTekstObject.SetActive(false);
    }

    void activeerStukje(stukjeVarianten variant)
    {
        //Debug.Log("variant in hand is: " + variant);

        foreach (GameObject geplaatstStukje in geplaatsteStukjes)
        {
            if (geplaatstStukje.GetComponent<winterStukken>().stukjeVariant == variant)
            {
                //Debug.Log("dit is hem wel: " + geplaatstStukje.GetComponent<winterStukken>().stukjeVariant);
                geplaatstStukje.SetActive(true);
                //geplaatstStukje.
            }
            else
            {
                //Debug.Log("dit is hem niet: " + geplaatstStukje.GetComponent<winterStukken>().stukjeVariant);
                continue;
            }
            
        }
    }

    public void plaatsBloem(GameObject bloemInKwestie)
    {        
        bloemInKwestie.transform.parent = transform;
        bloemInKwestie.transform.position = transform.position;
        StartCoroutine(machineUitElkaarVallen());
    }

    IEnumerator machineUitElkaarVallen()
    {
        plaatsTekst.DOFade(0, 2f);
        yield return new WaitForSeconds(1.5f);
        foreach (GameObject stukje in geplaatsteStukjes)
        {
            stukje.GetComponent<Animator>().speed = 5f;
        }
        yield return new WaitForSeconds(2f);
        foreach (GameObject stukje in geplaatsteStukjes)
        {
            stukje.GetComponent<BoxCollider2D>().enabled = true;
            stukje.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        yield return new WaitForSeconds(6f);
        alsMachineKlaar.Invoke();
    }
}