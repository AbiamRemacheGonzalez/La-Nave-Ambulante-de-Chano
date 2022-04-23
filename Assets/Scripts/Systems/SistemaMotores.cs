using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaMotores : SystemBase
{
    public static float currentEngineeringStat;
    public override void DisplayInfo()
    {
        throw new System.NotImplementedException();
    }

    public override void DoTask(Chano chano)
    {
        if (life < maxLife)
        {
            Repair(chano);
        }
        else
        {
            currentEngineeringStat = chano.GetStats().GetEngineering();
            Debug.Log("Se esta usando los motores");
            chano.GetStats().SetEngineering(chano.GetStats().GetEngineering() + 1);
        }
    }
}
