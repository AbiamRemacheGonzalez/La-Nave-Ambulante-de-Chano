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

    protected override void Task(Chano chano)
    {
        currentEngineeringStat = chano.GetStats().GetEngineering();
        Debug.Log("Se esta usando los motores");
        chano.GetStats().SetEngineering(chano.GetStats().GetEngineering() + 1);
    }
}
