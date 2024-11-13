using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winterRegelaar : MonoBehaviour
{
    public int spelerKlaarTeller;

    public void doorgaanCheck()
    {
        if (spelerKlaarTeller >=2)
        {
            StartCoroutine(klaar());
        }
    }

    IEnumerator klaar()
    {
        yield return new WaitForSeconds(6);
        Debug.Log("scene klaar");
        //SceneManager.LoadScene(1);
    }
}