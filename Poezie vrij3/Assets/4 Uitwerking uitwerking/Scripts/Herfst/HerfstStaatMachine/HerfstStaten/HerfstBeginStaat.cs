using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerfstBeginStaat : HerfstBasisStaat
{
    HerfstRegelaar herfstRegelRef;

    private void Start()
    {
        herfstRegelRef = GetComponent<HerfstRegelaar>();
        GetComponent<HerfstAgent>().huidigeStaat = HerfstAgent.herfstStaten.HerfstStartStaat;
    }

    public override void OnEnter()
    {
        StartCoroutine(beginRoutine());
    }
    IEnumerator beginRoutine()
    {
        //fade in
        yield return new WaitForSeconds(1f);
        owner.SwitchState(typeof(HerfstGroei1));
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        
    }
}