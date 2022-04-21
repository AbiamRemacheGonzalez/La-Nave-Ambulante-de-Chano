using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaCuadroDeMando : SystemBase
{
    public GameObject cuadroDeMando;

    public override void DoTask()
    {
        if (life < maxLife)
        {
            Repair();
        }
        else
        {
            cuadroDeMando.SetActive(true);
        }
    }

    public override void DisplayInfo()
    {
        
    }
}
