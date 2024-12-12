using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerfstBeginStaat : HerfstBasisStaat
{
    HerfstRegelaar herfstRegelRef;

    private void Start()
    {
        herfstRegelRef = GetComponent<HerfstRegelaar>();
    }

    public override void OnEnter()
    {
        
        

    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        
    }
}