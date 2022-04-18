using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    private static int count = 0;
    
    private float speed;
    private float piloting;
    private float repairing;
    private float shooting;
    private float engineering;
    private float healing;

    public static Stats GenerateStats()
    {
        Stats stats = new Stats();

        switch (count)
        {
            case 0:
                stats.SetPiloting(20);
                count++;
                break;

            case 1:
                stats.SetRepairing(20);
                count++;
                break;

            case 2:
                stats.SetShooting(20);
                count++;
                break;

            case 3:
                stats.SetEngineering(20);
                count++;
                break;

            default:
                break;
        }

        return stats;
    }

    public Stats()
    {
        speed = 5;
        piloting = 0;
        repairing = 0;
        shooting = 0;
        engineering = 0;
        healing = 0;
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void SetPiloting(float piloting)
    {
        this.piloting = piloting;
    }

    public void SetRepairing(float repairing)
    {
        this.repairing = repairing;
    }

    public void SetShooting(float shooting)
    {
        this.shooting = shooting;
    }

    public void SetEngineering(float engineering)
    {
        this.engineering = engineering;
    }

    public void SetHealing(float healing)
    {
        this.healing = healing;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public float GetPiloting()
    {
        return piloting;
    }

    public float GetRepairing()
    {
        return repairing;
    }

    public float GetShooting()
    {
        return shooting;
    }

    public float GetEngineering()
    {
        return engineering;
    }

    public float GetHealing()
    {
        return healing;
    }

}
