using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShip : MonoBehaviour
{
    protected List<SystemBase> systems;
    protected float fuel = 100;
    public const int maxFuel = 100;
    public Slider fuelSlider;

    private void Start()
    {
        fuelSlider.maxValue = maxFuel;
        fuelSlider.value = fuel;
    }

    public float GetFuel()
    {
        return fuel;
    }

    public void AddFuel(float fuel)
    {
        this.fuel = ((this.fuel+fuel) > maxFuel) ? maxFuel : this.fuel+fuel;
        fuelSlider.value = fuel;
    }

    public void RemoveFuel(float fuel)
    {
        this.fuel = ((this.fuel - fuel) < 0) ? 0 : this.fuel - fuel;
        fuelSlider.value = fuel;
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
