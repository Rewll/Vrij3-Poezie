using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WederLiefdeOppaker : MonoBehaviour
{
    public string spelerTag;
    public UnityEvent alsOpgepakt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == spelerTag)
        {
            collision.transform.parent = transform;
            collision.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            alsOpgepakt.Invoke();
        }
    }
}
