using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SamenPlukChecker : MonoBehaviour
{
    public bloem bloem1;
    public bloem bloem2;
    public bool klaar = false;
    [Space]
    public UnityEvent onSamenGeplukt;

    // Update is called once per frame
    void Update()
    {
        if (bloem1.isOpgeraapt && bloem2.isOpgeraapt && !klaar)
        {
            klaar = true;
            Debug.Log("Samengeplukt hihi");
            onSamenGeplukt.Invoke();
        }
    }
}