using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaCuadroDeMando : SystemBase
{
    public GameObject cuadroDeMando;
    public static float currentPilotingStat;

    public override void DoTask(Chano chano)
    {
        if (life < maxLife)
        {
            Repair(chano);
        }
        else
        {
            currentPilotingStat = chano.GetStats().GetPiloting();
            cuadroDeMando.SetActive(true);
            chano.GetStats().SetPiloting(chano.GetStats().GetPiloting() + 1);
        }
    }

    public override void DisplayInfo()
    {
        
    }
}
