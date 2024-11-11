using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class botser : MonoBehaviour
{
    public UnityEvent padBouw;
    [Space]
    public GameObject stukjePrefab;
    public GameObject stukjePrefabPlek1;
    public GameObject stukjePrefabPlek2;
    public GameObject tekst;
    public GameObject tekstuit;
    [Space]
    public List<GameObject> padDelen = new List<GameObject>();
    [Space]
    public int padOnthullerTeller;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<padOpraapScript>())
        {
            if (collision.gameObject.GetComponent<padOpraapScript>().handGevuld && padOnthullerTeller <= padDelen.Count)
            {
                Debug.Log("pad bouwen!");
                padBouw.Invoke();
                bouwPad();
                if (padOnthullerTeller < 4)
                {
                    NieuwStukje();
                }
                else
                {
                    tekst.SetActive(true);
                    tekstuit.SetActive(false);
                }
            }
            else
            {
                Debug.Log("Bots!");
            }
        }
    }

    public void bouwPad()
    {
        if (padOnthullerTeller <= padDelen.Count)
        {
            padDelen[padOnthullerTeller].SetActive(true);
            padOnthullerTeller++;
        }
    }

    public void NieuwStukje()
    {
        Instantiate(stukjePrefab, stukjePrefabPlek1.transform.position, Quaternion.identity);
        Instantiate(stukjePrefab, stukjePrefabPlek2.transform.position, Quaternion.identity);
    }
}
