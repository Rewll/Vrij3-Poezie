using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpelerBeweging : MonoBehaviour
{
    public InputActionReference inputActie;
    [Space]
    public Vector2 beweegRichting;
    public float beweegSnelheid = 20.0f;

    Rigidbody2D RB;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        beweegRichting = inputActie.action.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        RB.velocity = new Vector2(beweegRichting.x * beweegSnelheid, beweegRichting.y * beweegSnelheid);
    }
}