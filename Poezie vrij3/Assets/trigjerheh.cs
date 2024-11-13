using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigjerheh : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<SpelerBeweging>())
        {
            Debug.Log("volgende scene!");
            SceneManager.LoadScene(2);
        }
    }
}
