using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShip : MonoBehaviour
{
    public static SpaceShip instance;

    protected List<SystemBase> systems;
    protected float fuel = 100;
    public const int maxFuel = 100;
    public Slider fuelSlider;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        fuelSlider.maxValue = maxFuel;
        fuelSlider.value = fuel;
    }

    public float GetFuel()
    {
        return fuel;
    }

    public void AddFuel(float fuelToAdd)
    {
        fuel = ((fuel + fuelToAdd) > maxFuel) ? maxFuel : fuel + fuelToAdd;
        fuelSlider.value = fuel;
    }

    public void RemoveFuel(float fuelToRemove)
    {
        fuel = ((fuel - fuelToRemove) < 0) ? 0 : fuel - fuelToRemove;
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
