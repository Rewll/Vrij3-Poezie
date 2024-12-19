using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WederLiefdeAgent : MonoBehaviour
{
    public System.Type startState;
    private WederLiefdeFSM fsm;
    public enum WederLiefdeFSMStaten { WederliefdeStartStaat, 
                                       WederliefdeRepareer1, 
                                       WederliefdeRepareer2, 
                                       WederliefdeRepareer3,
                                       WederliefdeRepareer4, 
                                       WederliefdeVereniging }

    public WederLiefdeFSMStaten huidigeStaat;

    void Start()
    {
        switch (huidigeStaat)
        {
            case WederLiefdeFSMStaten.WederliefdeStartStaat:
                startState = typeof(WederliefdeStartStaat);
                break;
            case WederLiefdeFSMStaten.WederliefdeRepareer1:
                startState = typeof(WederliefdeRepareer1);
                break;
            case WederLiefdeFSMStaten.WederliefdeRepareer2:
                startState = typeof(WederliefdeRepareer2);
                break;
            case WederLiefdeFSMStaten.WederliefdeRepareer3:
                startState = typeof(WederliefdeRepareer3);
                break;
            case WederLiefdeFSMStaten.WederliefdeRepareer4:
                startState = typeof(WederliefdeRepareer4);
                break;
            case WederLiefdeFSMStaten.WederliefdeVereniging:
                startState = typeof(WederliefdeVereniging);
                break;
        }
        fsm = new WederLiefdeFSM(startState, GetComponents<WederLiefdeBasisStaat>()); //Starting state, with getcomponentSSS because multiple states are being used
    }

    void Update()
    {
        fsm.OnUpdate();
    }
}
