using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chano : Character
{
    private Stats stats;

    public override void MoveTo(Node node)
    {
        
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
