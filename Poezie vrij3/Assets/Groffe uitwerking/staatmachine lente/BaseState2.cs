using UnityEngine;

public abstract class BaseState2 : MonoBehaviour
{
    protected FSM2 owner;
    public void Initalize(FSM2 owner)
    {
        this.owner = owner;
    }
    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnExit();
}