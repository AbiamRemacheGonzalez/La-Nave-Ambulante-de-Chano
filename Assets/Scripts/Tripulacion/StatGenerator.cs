using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatGenerator : MonoBehaviour
{
    public Stats Generate()
    {
        return Stats.GenerateStats();
    }
}
