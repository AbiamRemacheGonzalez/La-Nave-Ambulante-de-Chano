using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanoGenerator : MonoBehaviour
{
    public GameObject chanoPrefab;
    public StatGenerator statGenerator;

    public GameObject Generate()
    {
        GameObject chano = Instantiate(chanoPrefab);
        Stats stats = statGenerator.Generate();
        chano.GetComponent<Chano>().SetStats(stats);
        return chano;
    }

}
