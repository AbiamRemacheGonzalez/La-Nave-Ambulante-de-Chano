using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDefensas : SystemBase
{
    public static float currentShootingStat;
    public override void DisplayInfo()
    {
        throw new System.NotImplementedException();
    }

    protected override void Task(Chano chano)
    {
        currentShootingStat = chano.GetStats().GetShooting();
        Debug.Log("Se esta usando el sistema de defensa.");
        chano.GetStats().SetShooting(chano.GetStats().GetShooting() + 1);
    }
}
