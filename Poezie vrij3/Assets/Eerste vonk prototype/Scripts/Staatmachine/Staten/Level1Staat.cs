using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Staat : BaseState
{
    public GameObject Level1Camera;

    public override void OnEnter()
    {
        Debug.Log("hoi");
        //Verplaats spelers
        //Camera aan
        //Fade in
        // Laat bloem verschijnen
    }

    public override void OnUpdate()
    {
        // Als geplukt: weer fade naar zwart
        //Als beide spelers de tweede geplukt hebben: naar volgende staat
    }

    public override void OnExit()
    {
        //Camerauit
    }
}
