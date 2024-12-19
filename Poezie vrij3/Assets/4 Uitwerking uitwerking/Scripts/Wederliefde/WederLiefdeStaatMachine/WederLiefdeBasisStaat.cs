using UnityEngine;

public abstract class WederLiefdeBasisStaat : MonoBehaviour
{
    protected WederLiefdeFSM owner;
    public void Initalize(WederLiefdeFSM owner)
    {
        this.owner = owner;
    }
    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnExit();

}