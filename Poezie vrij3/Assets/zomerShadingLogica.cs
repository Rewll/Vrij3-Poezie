using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zomerShadingLogica : MonoBehaviour
{
    public ZomerOpslag regelaarRef;
    public Material mat;

    private void Update()
    {
        mat.SetFloat("_Fade", lerpUitrekenaar(regelaarRef.speler1.transform, regelaarRef.speler2.transform, 5));
        mat.SetFloat("_Saturation", lerpUitrekenaar(regelaarRef.speler1.transform, regelaarRef.speler2.transform, 5));
        //mat.SetFloat("_Fade", 0.2f);
        //mat.SetFloat("_Saturation", 0.2f);
    }

    public float lerpUitrekenaar(Transform pos1, Transform pos2, float maxAfstand)
    {
        float afstand = (Vector2.Distance(pos1.position,
                                          pos2.position));
        float afstand2 = Mathf.Min(afstand, maxAfstand);

        return (afstand2 / maxAfstand);
    }
}