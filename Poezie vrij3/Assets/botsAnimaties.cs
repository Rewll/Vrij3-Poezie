using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botsAnimaties : MonoBehaviour
{
    public GameObject botsParticlesObject;

    int botsTeller = 0;

    Animator botsAnim;
    private HartBotsing botsingRef;

    void Start()
    {
        botsingRef = GetComponent<HartBotsing>();
        botsAnim = botsParticlesObject.GetComponent<Animator>();
    }

    public void lenteBotsAnimatie()
    {
        botsParticlesObject.transform.position = botsingRef.midden;
        botsTeller++;
        switch (botsTeller)
        {
            case 1:
                botsAnim.SetTrigger("AnimTrig");
                botsAnim.SetInteger("BotsingAnimatieTel", 1);
                break;
            case 2:
                botsAnim.SetTrigger("AnimTrig");
                botsAnim.SetInteger("BotsingAnimatieTel", 1);
                break;
            case 3:
                botsAnim.SetTrigger("AnimTrig");
                botsAnim.SetInteger("BotsingAnimatieTel", 2);
                break;
            case 4:
                botsAnim.SetTrigger("AnimTrig");
                botsAnim.SetInteger("BotsingAnimatieTel", 2);
                break;
            case 5:
                botsAnim.SetTrigger("AnimTrig");
                botsAnim.SetInteger("BotsingAnimatieTel", 3);
                break;
            case 6:
                botsAnim.SetTrigger("AnimTrig");
                botsAnim.SetInteger("BotsingAnimatieTel", 3);
                break;
        }
    }
}