using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanoGenerator : MonoBehaviour
{
    public GameObject chanoPrefab;

    public GameObject Generate()
    {
        GameObject chano = Instantiate(chanoPrefab);
        return chano;
    }

}
