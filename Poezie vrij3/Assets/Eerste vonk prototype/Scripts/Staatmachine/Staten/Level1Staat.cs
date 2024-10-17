using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Staat : BaseState
{
    public GameObject Level1Camera;

    public override void OnEnter()
    {
        Debug.Log("hoi");
        //Camera aan
        Level1Camera.SetActive(true);
        //Verplaats spelers
        //Fade de vlakken weg
        //Laat bloem verschijnen
    }

    public override void OnUpdate()
    {
        // Als geplukt: weer fade naar zwart
        //Als beide spelers de tweede geplukt hebben: naar volgende staat
    }

    public override void OnExit()
    {
        //Camerauit
        //fade de vlakken terug
    }
}
