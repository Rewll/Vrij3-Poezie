using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloemenSpawner : MonoBehaviour
{
    public GameObject bloemSetPrefab;
    [Space]
    public List<GameObject> plekkenVoorBloemenSetjes = new List<GameObject>();
    private int index;

    public void nieuweBloem()
    {
        int nieuweIndex = Random.Range(0, plekkenVoorBloemenSetjes.Count);
        while (index == nieuweIndex)
        {
            Debug.Log("Het is dezelfde LOL");
            nieuweIndex = Random.Range(0, plekkenVoorBloemenSetjes.Count);
        }
        index = nieuweIndex;
        GameObject nieuweBloemSet = Instantiate(bloemSetPrefab);
        nieuweBloemSet.GetComponent<SamenBloemChecker>().spawnerRef = gameObject.GetComponent<bloemenSpawner>();

        Vector2 anjerPlek = plekkenVoorBloemenSetjes[index].transform.GetChild(0).transform.position;
        Vector2 narcisPlek = plekkenVoorBloemenSetjes[index].transform.GetChild(1).transform.position;
        nieuweBloemSet.GetComponent<SamenBloemChecker>().PlaatsBloem(anjerPlek, narcisPlek);
    }
}