using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hartlogica : MonoBehaviour
{
    public bool speler1;
    public bool speler2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speler1 && speler2)
        {
            Debug.Log("Volgende!");
            SceneManager.LoadScene(1);
        }   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<bloemOpraap>())
        {
            speler1 = true;
        }
        if (collision.GetComponent<BOTS>())
        {
            speler2 = true;
        }
    }
}
