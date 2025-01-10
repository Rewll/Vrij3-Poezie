using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimatieRegelBedoeling : MonoBehaviour
{
    public List<GameObject> animaties = new List<GameObject>();
    public int startClip;
    public int huidigeAnimatieNummer;

    public void crossfade(int animatieNummerOmNaarTeCrossFaden, float crossFadeTijd)
    {
        animaties[huidigeAnimatieNummer].GetComponent<SpriteRenderer>().DOFade(0, crossFadeTijd);
        animaties[animatieNummerOmNaarTeCrossFaden].GetComponent<SpriteRenderer>().DOFade(1, crossFadeTijd);
        huidigeAnimatieNummer = animatieNummerOmNaarTeCrossFaden;
    }

    public void WederCrossFade(GameObject stilstaand, GameObject bewegendHart, GameObject bewegendBloem, float crossFadeTijd)
    {
        stilstaand.GetComponent<SpriteRenderer>().DOFade(0, crossFadeTijd);
        bewegendHart.GetComponent<SpriteRenderer>().DOFade(1, crossFadeTijd);
        bewegendBloem.GetComponent<SpriteRenderer>().DOFade(1, crossFadeTijd);
    }

    public void herfstCrossfade()
    {

    }

    public void animatieStart()
    {
        huidigeAnimatieNummer = startClip;
        foreach (GameObject animatie in animaties)
        {
            if (animaties.IndexOf(animatie) == startClip)
            {
                continue;
            }
            else
            {
                animatie.GetComponent<SpriteRenderer>().DOFade(0, 0.001f);
            }
        }
    }
}