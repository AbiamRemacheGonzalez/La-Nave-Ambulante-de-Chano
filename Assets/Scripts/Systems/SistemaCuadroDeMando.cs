using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaCuadroDeMando : SystemBase
{
    public GameObject cuadroDeMando;
    public static float currentPilotingStat;
    public GalaxyController galaxyController;

    public override void DisplayInfo()
    {
        
    }

    protected override void Task(Chano chano)
    {
        if (galaxyController.navController.IsTraveling())
        {
            return;
        }

        currentPilotingStat = chano.GetStats().GetPiloting();
        galaxyController.UpdateValues();
        cuadroDeMando.SetActive(true);
        chano.GetStats().SetPiloting(chano.GetStats().GetPiloting() + 1);
    }
}
