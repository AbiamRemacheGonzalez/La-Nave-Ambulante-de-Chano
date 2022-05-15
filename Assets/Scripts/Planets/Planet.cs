using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet
{
    protected string planetName;
    protected Vector2 position;

    public Planet(string name, Vector2 pos)
    {
        planetName = name;
        position = pos;
    }

    public string GetName()
    {
        return planetName;
    }

    public Vector2 GetPosition()
    {
        return position;
    }

    public float DistanceFrom(Planet planet)
    {
        return (position - planet.GetPosition()).magnitude * 50;
    }
}
