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
        regelaarOpslag.knopIndicatorsUitZetten(1);
    }
    public override void OnUpdate()
    {

    }


    public override void OnExit()
    {

    }
}