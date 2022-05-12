using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator
{

    private const int MAX_PLANETS = 5;

    private static string[] planetsName =
    {
        "Venus", "Marte", "Jupiter", "Saturno", "Urano"
    };

    private static Vector2[] planetPositions =
    {
        new Vector2(0, 0), new Vector2(1, 0), new Vector2(0, 1), new Vector2(3, 0), new Vector2(2, 0), new Vector2(0, 2)
    };

    public static Planet[] GeneratePlanets()
    {
        Planet[] planets = new Planet[MAX_PLANETS];

        for(int i = 0; i < planets.Length; i++)
        {
            planets[i] = new Planet(planetsName[i], planetPositions[i]);
        }

        return planets;
    }
}
