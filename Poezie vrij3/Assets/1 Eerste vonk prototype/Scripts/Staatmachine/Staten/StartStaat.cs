using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartStaat : BaseState
{
    public override void OnEnter()
    {
        
    }

    public override void OnUpdate()
    {

    }

    public override void OnExit()
    {

    }

    public void begin()
    {
        owner.SwitchState(typeof(TutorialStaat));
    }
}