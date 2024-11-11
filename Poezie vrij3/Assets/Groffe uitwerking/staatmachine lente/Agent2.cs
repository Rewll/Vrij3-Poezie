using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent2 : MonoBehaviour
{
    private FSM2 fsm;
    // Start is called before the first frame update
    void Start()
    {
        fsm = new FSM2(typeof(LenteStart), GetComponents<BaseState2>()); //Starting state, with getcomponentSSS because multiple states are being used
    }

    // Update is called once per frame
    void Update()
    {
        fsm.OnUpdate();
    }
}