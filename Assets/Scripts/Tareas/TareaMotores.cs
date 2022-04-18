using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaMotores : Tarea
{
    public override void DisplayInfo()
    {
        throw new System.NotImplementedException();
    }

    public override void DoTask()
    {
        Debug.Log("Se esta usando los motores");
    }
}
