using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripulacionSpawnController : MonoBehaviour
{
    public Node[] spawnPoints;
    public ChanoGenerator chanoGenerator;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Node spawnPoint in spawnPoints)
        {
            GameObject chano = chanoGenerator.Generate();
            chano.GetComponent<Chano>().SetNode(spawnPoint);
            chano.transform.position = spawnPoint.gameObject.transform.position;
        }
    }

}
