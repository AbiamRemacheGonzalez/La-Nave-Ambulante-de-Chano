using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SystemBase : Tarea
{
    protected int life = 10;
    public const int maxLife = 10;

    public int GetLife()
    {
        return life;
    }

    public void Setlife(int newLife)
    {
        life = (newLife > maxLife) ? maxLife : (newLife < 0) ? 0 : newLife;
    }

    public void Repair()
    {
        life = maxLife;
        Debug.Log("Se esta reparando");
        DoTask();
    }
}
