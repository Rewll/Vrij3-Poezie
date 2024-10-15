using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelerBeweging : MonoBehaviour
{
    Rigidbody2D RB;
    float horizontaal;
    float verticaal;
    float moveLimiter = 0.7f;

    public float beweegSnelheid = 20.0f;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontaal = Input.GetAxisRaw("Horizontal"); 
        verticaal = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate()
    {
        if (horizontaal != 0 && verticaal != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontaal *= moveLimiter;
            verticaal *= moveLimiter;
        }
        RB.velocity = new Vector2(horizontaal * beweegSnelheid, verticaal * beweegSnelheid);
    }
}