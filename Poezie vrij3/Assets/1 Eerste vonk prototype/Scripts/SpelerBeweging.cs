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
    [Space]
    public bool moetTerugVliegen;
    public Transform middenPunt;
    public float terugBeweegSnelheid;
    float xAfstandTotMidden;
    public float maxX;
    float yAfstandTotMidden;
    public float maxY;
    public bool spelerInZicht;

    private bool magBewegen = true;
    private bool recoilBezig;

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
        if (moetTerugVliegen)
        {
            buitenSchermCheck();
        }
    }

    void FixedUpdate()
    {
        if (magBewegen)
        {
            RB.velocity = new Vector2(beweegRichting.x * beweegSnelheid, beweegRichting.y * beweegSnelheid);
        }
        if (moetTerugVliegen)
        {
            if (!spelerInZicht && !recoilBezig && beweegRichting == Vector2.zero)
            {
                magBewegen = false;
                beweegSpelerTerug();
            }
            else if (spelerInZicht && !recoilBezig && !magBewegen)
            {
                magBewegen = true;
            }
        }
    }

    public void beweegTerugBeetje(float beweegHoeveelheid)
    {
        recoilBezig = true;
        RB.velocity = Vector2.zero;
        magBewegen = false;
        //Debug.Log("BeweegtTerug");
        Vector2 richting = (andereSpeler.transform.position - transform.position).normalized;
        RB.AddForce(-richting * beweegHoeveelheid, ForceMode2D.Impulse);
        StartCoroutine(bewegingWachter());
    }

    IEnumerator bewegingWachter()
    {
        yield return new WaitForSeconds(1f);
        recoilBezig = false;
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

    void buitenSchermCheck()
    {
        xAfstandTotMidden = Mathf.Abs(transform.position.x -middenPunt.position.x);
        yAfstandTotMidden = Mathf.Abs(transform.position.y - middenPunt.position.y);

        if (yAfstandTotMidden > maxY || xAfstandTotMidden > maxX)
        {
            spelerInZicht = false;
        }
        else if (yAfstandTotMidden < (maxY - 0.5f) && yAfstandTotMidden < (maxY - 0.5f))
        {
            spelerInZicht = true;
        }
    }

    void beweegSpelerTerug()
    {
        Vector2 richting = (middenPunt.position - transform.position).normalized;
        RB.AddForce(richting * terugBeweegSnelheid);
    }
}