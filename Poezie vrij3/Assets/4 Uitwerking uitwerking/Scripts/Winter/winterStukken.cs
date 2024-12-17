using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum stukjeSpeler { Speler1, Speler2 }
public enum stukjeVarianten { Anjer1, Anjer2, Anjer3, Anjer4, Narcis1, Narcis2, Narcis3, Narcis4 }

public class winterStukken : MonoBehaviour
{
    public stukjeSpeler voorWieStukIs;
    public stukjeVarianten stukjeVariant;
}