using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SamenBloemChecker : MonoBehaviour
{
    public UnityEvent beideGeplukt;
    public int plukTeller;
    public void plukTellen()
    {
        plukTeller++;
        if (plukTeller >= 2)
        {
            beideGeplukt.Invoke();
        }
    }
}
