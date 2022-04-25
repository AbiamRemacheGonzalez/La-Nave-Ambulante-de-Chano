using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaOxigeno : SystemBase
{
    protected float oxigenLevel = 100;
    protected float maxOxigenLevel = 100;
    public Slider oxygenSlider;

    private void Start()
    {
        oxygenSlider.maxValue = maxOxigenLevel;
        oxygenSlider.value = oxigenLevel;
    }

    public override void TakeDamage(int damage)
    {
        life = ((life - damage) < 0) ? 0 : life - damage;
        oxigenLevel = ((oxigenLevel - damage * 10) < 0) ? 0 : oxigenLevel - damage * 10;
        oxygenSlider.value = oxigenLevel;
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

    protected override void Task(Chano chano)
    {
        oxigenLevel = 100;
        oxygenSlider.value = oxigenLevel;
        Debug.Log("Se esta usando la tarea oxigeno");
    }
}
