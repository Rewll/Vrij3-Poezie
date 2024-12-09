using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomerEinde : ZomerBasisStaat
{
    ZomerOpslag regelaarOpslag;

    private void Awake()
    {
        regelaarOpslag = GetComponent<ZomerOpslag>();
    }

    public override void OnEnter()
    {
        GetComponent<ZomerAgent>().huidigeStaat = ZomerAgent.ZomerFsmStaten.ZomerEinde;
        regelaarOpslag.knopIndicatorsUitZetten();
    }
    public override void OnUpdate()
    {
        throw new System.NotImplementedException();
    }


    public override void OnExit()
    {
        throw new System.NotImplementedException();
    }
}