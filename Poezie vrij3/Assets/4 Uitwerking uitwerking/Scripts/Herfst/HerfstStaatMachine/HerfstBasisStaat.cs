using UnityEngine;

public abstract class HerfstBasisStaat : MonoBehaviour
{
    protected HerfstFSM owner;
    public void Initalize(HerfstFSM owner)
    {
        this.owner = owner;
    }
    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnExit();
}