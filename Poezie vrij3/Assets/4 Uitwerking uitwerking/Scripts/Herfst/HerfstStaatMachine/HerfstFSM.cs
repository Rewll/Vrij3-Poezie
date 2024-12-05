using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerfstFSM
{
    private Dictionary<System.Type, HerfstBasisStaat> stateDictionary = new Dictionary<System.Type, HerfstBasisStaat>();
    private HerfstBasisStaat currentState;
    public HerfstFSM(System.Type startState, params HerfstBasisStaat[] states)
    {
        foreach (HerfstBasisStaat state in states)
        {
            state.Initalize(this);
            stateDictionary.Add(state.GetType(), state);
        }
        SwitchState(startState);
    }
    public void OnUpdate()
    {
        currentState?.OnUpdate();
    }
    public void SwitchState(System.Type newStateType)
    {
        currentState?.OnExit();
        currentState = stateDictionary[newStateType];
        currentState?.OnEnter();
    }
}
