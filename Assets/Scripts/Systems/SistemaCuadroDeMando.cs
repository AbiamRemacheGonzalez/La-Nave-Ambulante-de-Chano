using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaCuadroDeMando : SystemBase
{
    public GameObject cuadroDeMando;
    public static float currentPilotingStat;

    public override void DisplayInfo()
    {
        
    }

    protected override void Task(Chano chano)
    {
        currentPilotingStat = chano.GetStats().GetPiloting();
        cuadroDeMando.SetActive(true);
        chano.GetStats().SetPiloting(chano.GetStats().GetPiloting() + 1);
    }
}
