using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LenteAgent : MonoBehaviour
{
    private LenteFSM fsm;
    void Start()
    {
        fsm = new LenteFSM(typeof(LenteStartStaat), GetComponents<LenteBasisStaat>()); //Starting state, with getcomponentSSS because multiple states are being used
    }

    void Update()
    {
        fsm.OnUpdate();
    }
}