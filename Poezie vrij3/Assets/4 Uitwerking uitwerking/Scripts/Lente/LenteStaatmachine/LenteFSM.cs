using System.Collections;
using System.Collections.Generic;

public class LenteFSM
{
    private Dictionary<System.Type, LenteBasisStaat> stateDictionary = new Dictionary<System.Type, LenteBasisStaat>();
    private LenteBasisStaat currentState;
    public LenteFSM(System.Type startState, params LenteBasisStaat[] states)
    {
        foreach (LenteBasisStaat state in states)
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
