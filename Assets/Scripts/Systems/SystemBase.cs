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

    public virtual void TakeDamage(int damage)
    {
        life = ((life - damage) < 0) ? 0 : life - damage;
    }

    public override void DoTask(Chano chano)
    {
        if (life < maxLife)
        {
            Repair(chano);
        }
        else
        {
            Task(chano);
            TakeDamage(1);
        }
    }

    protected abstract void Task(Chano chano);

    public void Repair(Chano chano)
    {
        life = maxLife;
        Debug.Log("Se esta reparando");
        chano.GetStats().SetRepairing(chano.GetStats().GetRepairing() + 1);
        DoTask(chano);
    }
}
