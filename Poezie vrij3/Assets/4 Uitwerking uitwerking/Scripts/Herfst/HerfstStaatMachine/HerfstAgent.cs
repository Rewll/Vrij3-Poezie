using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerfstAgent : MonoBehaviour
{
    public System.Type startState;
    private HerfstFSM fsm;
    public enum herfstStaten
    {HerfstStartStaat, HerfstGroei1, HerfstGroei2, HerfstGroei3}

    public herfstStaten huidigeStaat;

    void Start()
    {
        switch (huidigeStaat)
        {
            case herfstStaten.HerfstStartStaat:
                startState = typeof(HerfstBeginStaat);
                break;
            case herfstStaten.HerfstGroei1:
                startState = typeof(HerfstGroei1);
                break;
            case herfstStaten.HerfstGroei2:
                startState = typeof(HerfstGroei2);
                break;
            case herfstStaten.HerfstGroei3:
                startState = typeof(HerfstGroei3);
                break;
        }
        fsm = new HerfstFSM(startState, GetComponents<HerfstBasisStaat>()); //Starting state, with getcomponentSSS because multiple states are being used
    }

    void Update()
    {
        fsm.OnUpdate();
    }
}