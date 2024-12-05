using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomerAgent : MonoBehaviour
{
    public System.Type startState;
    private ZomerFSM fsm;
    public enum ZomerFsmStaten
    {
        ZomerStartStaat,
        ZomerLevel1,
        ZomerLevel2,
        ZomerLevel3,
        ZomerEinde
    }

    public ZomerFsmStaten huidigeStaat;

    void Start()
    {
        switch (huidigeStaat)
        {
            case ZomerFsmStaten.ZomerStartStaat:                            
                startState = typeof(ZomerStartStaat);
                break;
            case ZomerFsmStaten.ZomerLevel1:
                startState = typeof(ZomerLevel1);
                break;
            case ZomerFsmStaten.ZomerLevel2:
                startState = typeof(ZomerLevel2);
                break;
            case ZomerFsmStaten.ZomerLevel3:
                startState = typeof(ZomerLevel3);
                break;
            case ZomerFsmStaten.ZomerEinde:
                startState = typeof(ZomerEinde);
                break;
        }
        fsm = new ZomerFSM(startState, GetComponents<ZomerBasisStaat>()); //Starting state, with getcomponentSSS because multiple states are being used
    }

    void Update()
    {
        fsm.OnUpdate();
    }
}