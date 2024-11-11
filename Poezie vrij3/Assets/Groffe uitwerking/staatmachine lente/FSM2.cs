using System.Collections;
using System.Collections.Generic;

public class FSM2
{
    private Dictionary<System.Type, BaseState2> stateDictionary = new Dictionary<System.Type, BaseState2>();
    private BaseState2 currentState;
    public FSM2(System.Type startState, params BaseState2[] states)
    {
        foreach (BaseState2 state in states)
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
