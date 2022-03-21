using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripulacionSpawnController : MonoBehaviour
{
    public Transform[] spawnPoints;
    public ChanoGenerator chanoGenerator;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            GameObject chano = chanoGenerator.Generate();
            chano.transform.position = spawnPoint.position;
        }
    }

}
