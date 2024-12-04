using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class ZomerLevel1 : ZomerBasisStaat
{
    private Besturing besturing;
    public bool test;
    public InputActionReference mapje;

    private void Awake()
    {
        besturing = new Besturing();
        
        
    }

    private void OnEnable()
    {
        besturing.Enable();
    }

    private void OnDisable()
    {
        besturing.Disable();
    }
    public override void OnEnter()
    {

    }

    public override void OnUpdate()
    {
        test = besturing.ZomerSpeler1A.Knop1.ReadValue<float>() > 0;
        Debug.Log(besturing.ZomerSpeler1A.Knop1.GetBindingDisplayString());
        Debug.Log(besturing.controlSchemes[0]);


         
        
    }


    public override void OnExit()
    {

    }
}