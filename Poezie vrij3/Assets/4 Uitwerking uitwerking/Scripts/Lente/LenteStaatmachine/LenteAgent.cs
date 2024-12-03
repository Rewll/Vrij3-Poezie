using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LenteAgent : MonoBehaviour
{
    public System.Type startState;
    private LenteFSM fsm;
    public enum LenteFsmStaten
    {
        LenteStartStaat,
        LenteStuk1Staat,
        LenteVeldStaat,
        LenteBloemPlaatsStaat
    }

    public LenteFsmStaten startStaat;

    void Start()
    {
        switch (startStaat)
        {
            case LenteFsmStaten.LenteStartStaat:
                startState = typeof(LenteStartStaat);
                break;
            case LenteFsmStaten.LenteStuk1Staat:
                startState = typeof(LenteStuk1Staat);
                break;
            case LenteFsmStaten.LenteVeldStaat:
                startState = typeof(LenteVeldStaat);
                break;
            case LenteFsmStaten.LenteBloemPlaatsStaat:
                startState = typeof(LenteBloemPlaatsStaat);
                break;
        }
        fsm = new LenteFSM(startState, GetComponents<LenteBasisStaat>()); //Starting state, with getcomponentSSS because multiple states are being used
    }

    void Update()
    {
        fsm.OnUpdate();
    }
}