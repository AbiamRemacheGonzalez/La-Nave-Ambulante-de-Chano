using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCuadroDeMando : Tarea
{
    public GameObject cuadroDeMando;

    public override void DoTask()
    {
        cuadroDeMando.SetActive(true);
    }

    public override void DisplayInfo()
    {
        throw new System.NotImplementedException();
    }
}
