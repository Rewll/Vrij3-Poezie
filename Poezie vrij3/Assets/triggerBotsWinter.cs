using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerBotsWinter : MonoBehaviour
{
    public UnityEvent alsTriggerBots;
    public UnityEvent alsTriggerBotsVerlaat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Speler1")
        {
            //Debug.Log("Bots!");
            alsTriggerBots.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Speler1")
        {
                //Debug.Log("Bots!");
                alsTriggerBotsVerlaat.Invoke();
        }
    }
}