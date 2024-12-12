using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterAgent : MonoBehaviour
{
    public System.Type startState;
    private WinterFSM fsm;
    public enum winterStaten
    { WinterStartStaat }

    public winterStaten huidigeStaat;

    void Start()
    {
        switch (huidigeStaat)
        {
            case winterStaten.WinterStartStaat:
                startState = typeof(WinterStartStaat);
                break;
        }
        fsm = new WinterFSM(startState, GetComponents<WinterBasisStaat>()); //Starting state, with getcomponentSSS because multiple states are being used
    }

    void Update()
    {
        fsm.OnUpdate();
    }
}
