using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SystemBase : Tarea
{
    protected int life = 10;
    public const int maxLife = 10;
    public GameObject lifeBarObject;
    private LifeBarController lifeBar;

    private int count = 0;

    protected virtual void Start()
    {
        SpaceShip.instance.AddSystem(this);
        lifeBar = lifeBarObject.GetComponent<LifeBarController>();
        lifeBar.SetValuesTo(maxLife);
        lifeBarObject.SetActive(false);
    }

    public int GetLife()
    {
        return life;
    }

    public void SetLife(int newLife)
    {
        life = (newLife > maxLife) ? maxLife : (newLife < 0) ? 0 : newLife;
        UpdateLifeBar();
    }

    public virtual void TakeDamage(int damage)
    {
        life = ((life - damage) < 0) ? 0 : life - damage;
        UpdateLifeBar();
    }

    protected void UpdateLifeBar()
    {
        if (life < maxLife)
        {
            lifeBarObject.SetActive(true);
        }
        else
        {
            lifeBarObject.SetActive(false);
        }
        lifeBar.SetLife(life);
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
            if (count >= 5)
            {
                TakeDamage(1);
                count = 0;
            }
            else
            {
                count += Random.Range(1, 4);
            }
        }
    }

    protected abstract void Task(Chano chano);

    public void Repair(Chano chano)
    {
        SetLife(maxLife);
        Debug.Log("Se esta reparando");
        chano.GetStats().SetRepairing(chano.GetStats().GetRepairing() + 1);
        DoTask(chano);
    }
}