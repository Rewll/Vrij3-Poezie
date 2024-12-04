using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomerFSM
{
    private Dictionary<System.Type, ZomerBasisStaat> stateDictionary = new Dictionary<System.Type, ZomerBasisStaat>();
    private ZomerBasisStaat currentState;
    public ZomerFSM(System.Type startState, params ZomerBasisStaat[] states)
    {
        foreach (ZomerBasisStaat state in states)
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