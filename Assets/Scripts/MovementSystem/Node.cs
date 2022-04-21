using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node[] adyacentNodes;
    private bool occupied = false;
    private Tarea tarea;

    private void Start()
    {
        if (GetComponent<Tarea>() != null) {
            tarea = GetComponent<Tarea>();
        }
    }

    public void SetOccupied(bool state)
    {
        occupied = state;
    }

    public Tarea GetTarea() {
        return tarea;
    }

    public bool IsOccupied()
    {
        return occupied;
    }
}
