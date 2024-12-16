using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;


public class SpelerBeweging : MonoBehaviour
{
    public InputActionReference inputActie;
    [Space]
    public Vector2 beweegRichting;
    public float beweegSnelheid = 20.0f;
    public GameObject andereSpeler;
    private bool magBewegen = true;

    SpriteRenderer SP;

    Rigidbody2D RB;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        SP = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        beweegRichting = inputActie.action.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        if (magBewegen)
        {
            RB.velocity = new Vector2(beweegRichting.x * beweegSnelheid, beweegRichting.y * beweegSnelheid);
        }
    }

    public void beweegTerugBeetje(float beweegHoeveelheid)
    {
        RB.velocity = Vector2.zero;
        magBewegen = false;
        Debug.Log("BeweegtTerug");
        Vector2 richting = (andereSpeler.transform.position - transform.position).normalized;
        RB.AddForce(-richting * beweegHoeveelheid, ForceMode2D.Impulse);
        StartCoroutine(bewegingWachter());
    }

    IEnumerator bewegingWachter()
    {
        yield return new WaitForSeconds(1f);
        magBewegen = true;
    }

    public void wordtTransparant()
    {
        SP.DOFade(.2f, .6f);
    }

    public void wordtOpague()
    {
        SP.DOFade(1, .6f);
    }
}