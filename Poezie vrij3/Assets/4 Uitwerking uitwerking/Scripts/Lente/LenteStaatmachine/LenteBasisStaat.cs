using UnityEngine;

public abstract class LenteBasisStaat : MonoBehaviour
{
    protected LenteFSM owner;
    public void Initalize(LenteFSM owner)
    {
        this.owner = owner;
    }
    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnExit();
}