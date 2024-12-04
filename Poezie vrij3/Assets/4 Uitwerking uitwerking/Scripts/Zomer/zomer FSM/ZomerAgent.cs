using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomerAgent : MonoBehaviour
{
    public System.Type startState;
    private ZomerFSM fsm;
    public enum ZomerFsmStaten
    {
        ZomerStartStaat
    }

    public ZomerFsmStaten startStaat;

    void Start()
    {
        switch (startStaat)
        {
            case ZomerFsmStaten.ZomerStartStaat:
                startState = typeof(ZomerStartStaat);
                break;
        }
        fsm = new ZomerFSM(startState, GetComponents<ZomerBasisStaat>()); //Starting state, with getcomponentSSS because multiple states are being used
    }

    void Update()
    {
        fsm.OnUpdate();
    }
}