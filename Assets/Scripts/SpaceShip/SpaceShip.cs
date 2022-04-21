using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    protected List<SystemBase> systems;
    protected float fuel = 100;
    public const int maxFuel = 100;

    public float GetFuel()
    {
        return fuel;
    }

    public void AddFuel(float fuel)
    {
        this.fuel = ((this.fuel+fuel) > maxFuel) ? maxFuel : this.fuel+fuel;
    }

    public void RemoveFuel(float fuel)
    {
        this.fuel = ((this.fuel - fuel) < 0) ? 0 : this.fuel - fuel;
    }

    public void AddSystem(SystemBase system)
    {
        systems.Add(system);
    }

    public void RemoveSystem(SystemBase system)
    {
        systems.Remove(system);
    }
}
