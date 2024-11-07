using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padOpraapScript : MonoBehaviour
{
    public KeyCode opraapKnop;
    public GameObject stukjeInHand;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<padStukje>())
        {
            if (Input.GetKey(opraapKnop))
            {
                stukjeInHand = collision.gameObject;
                collision.transform.parent = transform;
            }
        }
    }
}
