using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class hartPlaatser : MonoBehaviour
{
    public UnityEvent alsbloemGeplaatst;
    public GameObject bloem1;
    public GameObject bloem2;
    public bool Klaar1;
    public bool Klaar2;

    private void Start()
    {
        bloem1.SetActive(false);    
        bloem2.SetActive(false);    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Speler1")
        {
            Destroy(collision.transform.GetChild(0).gameObject);
            bloem1.SetActive(true);
            Klaar1 = true;
        }

        if (collision.gameObject.tag == "Speler2")
        {
            Destroy(collision.transform.GetChild(0).gameObject);
            bloem2.SetActive(true);
            Klaar2 = true;
        }
    }

    private void Update()
    {
        if (Klaar1 && Klaar2)
        {
            alsbloemGeplaatst.Invoke();
        }
    }
}