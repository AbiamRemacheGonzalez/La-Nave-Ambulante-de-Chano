using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chano : Character
{
    private Stats stats;

    public override void MoveTo(Node node)
    {
        Node[] path = FindPath(node);

        foreach(Node n in path)
        {
            Debug.Log(n.gameObject);
        }
    }

    public void SetStats(Stats stats)
    {
        this.stats = stats;
    }

    public Stats GetStats()
    {
        return stats;
    }
}
