using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterFSM
{
    private Dictionary<System.Type, WinterBasisStaat> stateDictionary = new Dictionary<System.Type, WinterBasisStaat>();
    private WinterBasisStaat currentState;
    public WinterFSM(System.Type startState, params WinterBasisStaat[] states)
    {
        foreach (WinterBasisStaat state in states)
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
