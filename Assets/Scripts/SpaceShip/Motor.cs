using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    protected float currentPower;
    public const int maxPower = 100;
    protected bool stat;

    public void SetPower(float power)
    {
        this.currentPower = (power <= maxPower) ? power:maxPower;
    }
    public float GetPower()
    {
        return currentPower;
    }

    public void TurnOn()
    {
        stat = true;
    }

    public void TurnOff()
    {
        stat = false;
    }
}
