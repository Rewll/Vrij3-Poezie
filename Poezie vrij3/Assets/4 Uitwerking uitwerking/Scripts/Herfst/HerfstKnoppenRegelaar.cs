using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HerfstKnoppenRegelaar : MonoBehaviour
{
    public HerfstRegelaar herfstRegelRef;
    public IndicatorOpslag indicatorRef;
    [Space]
    public KeyCode huidigeknop;
    public bool klikCooldown;
    [Space]
    public List<KeyCode> Knoppen = new List<KeyCode>();
    [Space]
    public UnityEvent alsGeklikt;

    private void Start()
    {
        knopBepalen();
    }

    private void Update()
    {

    }

    public IEnumerator knopUitvoeren()
    {
        klikCooldown = true;
        yield return new WaitForSeconds(1f);
        indicatorRef.actief = false;
        alsGeklikt.Invoke();
        Debug.Log("knop gedrukt hoi");
        yield return new WaitForSeconds(1f);
        knopBepalen();
        yield return new WaitForSeconds(1f);
        indicatorRef.actief = true;
        klikCooldown = false;
    }


    public bool knoppenChecker()
    {
        if (Input.GetKey(huidigeknop))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void knopBepalen()
    {
        huidigeknop = Knoppen[Random.Range(0, Knoppen.Count)];
        updateKnopIndicator();
    }

    public void updateKnopIndicator()
    {
        indicatorRef.knop = huidigeknop;
        indicatorRef.indicatorInstel();
    }
}