using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    public Node[] adyacentNodes;
    private bool occupied = false;

    public void SetOccupied(bool state)
    {
        occupied = state;
    }

    public bool IsOccupied()
    {
        return occupied;
    }
}
