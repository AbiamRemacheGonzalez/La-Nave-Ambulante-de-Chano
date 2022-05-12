using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyController : MonoBehaviour
{
    public NavegationController navController;
    public GameObject planetUIParent;
    public GameObject planetUIChild;

    private Planet[] planets;
    private GameObject[] planetList = new GameObject[5];

    private Planet currentPlanet;

    // Start is called before the first frame update
    void Start()
    {
        planets = PlanetGenerator.GeneratePlanets();

        currentPlanet = planets[0];
        navController.SetCurrentPlanet(currentPlanet);

        for (int i = 0; i < planets.Length; i++)
        {
            planetList[i] = Instantiate(planetUIChild, planetUIParent.transform);
            CalculateTime ct = planetList[i].GetComponent<CalculateTime>();
            ct.SetPlanet(planets[i]);
            ct.UpdateValues(currentPlanet);
        }
    }

    public void UpdateValues()
    {
        currentPlanet = navController.GetCurrentPlanet();
        for (int i = 0; i < planets.Length; i++)
        {
            CalculateTime ct = planetList[i].GetComponent<CalculateTime>();
            ct.UpdateValues(currentPlanet);
        }
    }
}
