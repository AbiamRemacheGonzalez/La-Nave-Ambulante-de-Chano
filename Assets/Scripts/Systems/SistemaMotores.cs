using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaMotores : SystemBase
{
    public override void DisplayInfo()
    {
        throw new System.NotImplementedException();
    }

    public override void DoTask()
    {
        if (life < maxLife)
        {
            Repair();
        }
        else
        {
            Debug.Log("Se esta usando los motores");
        }
    }
}
