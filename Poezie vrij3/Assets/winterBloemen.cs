using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class winterBloemen : MonoBehaviour
{
    public winterBloem bloemSoort;
    [Space]
    public UnityEvent alsStukjesCompleet;
    [Space]
    public List<GameObject> stukjesInBloem = new List<GameObject>();
    public bool alleStukjesGeplaatst;

    public void plaatsStukje(GameObject stukje)
    {
        if (!alleStukjesGeplaatst)
        {
            stukje.transform.parent = transform;
            stukje.transform.position = transform.position;
            stukjesInBloem.Add(stukje);
        }
        if (stukjesInBloem.Count == 4)
        {
            alleStukjesGeplaatst = true;
            alsStukjesCompleet.Invoke();
        }
    }
}