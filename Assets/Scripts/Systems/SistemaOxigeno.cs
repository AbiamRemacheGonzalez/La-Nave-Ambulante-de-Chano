using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaOxigeno : SystemBase
{
    protected float oxigenLevel = 100;
    protected float maxOxigenLevel = 100;

    public override void TakeDamage(int damage)
    {
        this.life = ((this.life - damage) < 0) ? 0 : this.life - damage;
        this.oxigenLevel = ((this.oxigenLevel - damage * 10) < 0) ? 0 : this.oxigenLevel - damage * 10;
        if(oxigenLevel <= 0)
        {
            GameObject [] chanos = GameObject.FindGameObjectsWithTag("Chano");
            foreach(GameObject chano in chanos){
                chano.GetComponent<Chano>().SetLife(0);
            }
        }
    }

    public float GetOxigenLevel()
    {
        return oxigenLevel;
    }

    public override void DisplayInfo()
    {
        throw new System.NotImplementedException();
    }

    public override void DoTask(Chano chano)
    {
        if (life < maxLife)
        {
            Repair(chano);
        }
        else
        {
            oxigenLevel = 100;
            Debug.Log("Se esta usando la tarea oxigeno");
        }
    }

}
