using System.Collections;
using System.Collections.Generic;

public class WederLiefdeFSM
{
    private Dictionary<System.Type, WederLiefdeBasisStaat> stateDictionary = new Dictionary<System.Type, WederLiefdeBasisStaat>();
    private WederLiefdeBasisStaat currentState;
    public WederLiefdeFSM(System.Type startState, params WederLiefdeBasisStaat[] states)
    {
        foreach (WederLiefdeBasisStaat state in states)
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
