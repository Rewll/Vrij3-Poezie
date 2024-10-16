using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartStaat : BaseState
{

    public override void OnEnter()
    {
        owner.SwitchState(typeof(Level1Staat));
    }

    public override void OnUpdate()
    {

    }

    public override void OnExit()
    {

    }
}