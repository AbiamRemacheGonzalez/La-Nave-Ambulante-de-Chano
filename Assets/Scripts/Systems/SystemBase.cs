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
        this.life = ((this.life - damage) < 0) ? 0 : this.life - damage;
    }

    public void Repair(Chano chano)
    {
        life = maxLife;
        Debug.Log("Se esta reparando");
        chano.GetStats().SetRepairing(chano.GetStats().GetRepairing() + 1);
        DoTask(chano);
    }
}
