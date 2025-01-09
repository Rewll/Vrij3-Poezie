using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class hartHeelLogica : MonoBehaviour
{
    public GameObject narcisOpHart;
    public GameObject anjerOpHart;
    [Space]
    public bool speler1;
    public bool speler2;
    [Space]
    public UnityEvent alsBloemenGeplaatst;

    private void Start()
    {
        anjerOpHart.SetActive(false);
        narcisOpHart.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<SpelerBeweging>())
        {
            if (collision.gameObject.tag == "Speler1")
            {
                collision.transform.GetChild(0).gameObject.SetActive(false);
                anjerOpHart.SetActive(true);
                speler1 = true;
            }
            else if (collision.gameObject.tag == "Speler2")
            {
                collision.transform.GetChild(0).gameObject.SetActive(false);
                narcisOpHart.SetActive(true);
                speler2 = true;
            }
        }
    }

    private void Update()
    {
        if (speler1 && speler2)
        {
            StartCoroutine(alsBloemPlaatsLogica());
            speler1 = false;
            speler2 = false;
        }
    }

    IEnumerator alsBloemPlaatsLogica()
    {
        yield return new WaitForSeconds(1f);
        anjerOpHart.SetActive(false);
        narcisOpHart.SetActive(false);
        alsBloemenGeplaatst.Invoke();
    }
}