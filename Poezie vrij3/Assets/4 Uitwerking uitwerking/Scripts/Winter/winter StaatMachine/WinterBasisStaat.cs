using UnityEngine;

public abstract class WinterBasisStaat : MonoBehaviour
{
    protected WinterFSM owner;
    public void Initalize(WinterFSM owner)
    {
        this.owner = owner;
    }

    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnExit();
}