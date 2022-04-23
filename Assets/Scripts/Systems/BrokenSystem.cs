using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenSystem : SystemBase
{
    public override void DisplayInfo()
    {
        throw new System.NotImplementedException();
    }

    protected override void Task(Chano chano)
    {
        Debug.Log("Se esta usando la tarea rota");
    }

    // Start is called before the first frame update
    void Start()
    {
        life = 0;
    }
}
