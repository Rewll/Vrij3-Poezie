using UnityEngine;

public abstract class ZomerBasisStaat : MonoBehaviour
{
    protected ZomerFSM owner;
    public void Initalize(ZomerFSM owner)
    {
        this.owner = owner;
    }
    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnExit();
}
