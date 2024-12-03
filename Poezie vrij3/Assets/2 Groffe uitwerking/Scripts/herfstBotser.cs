using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herfstBotser : MonoBehaviour
{
    public int botsTeller;
    public int breekTeller;
    public bool botsende;
    public List<SpriteRenderer> padstukken = new List<SpriteRenderer>();
    [Space]
    public Color neutraleKleur;
    public Color botsKleur;
    [Space]
    public GameObject padhelft;
    public Transform padHelftBestemming;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            foreach (SpriteRenderer SR in padstukken)
            {
                SR.color = botsKleur;
            }

            botsTeller++;
            if (botsTeller > 1)
            {
                botsende = true;
                Debug.Log("breek!");
                botsTeller = 0;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpelerBeweging>())
        {
            foreach (SpriteRenderer SR in padstukken)
            {
                SR.color = neutraleKleur;
            }
         
            botsende = false;
        }
    }


}