using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculateTime : MonoBehaviour
{

    public TextMeshProUGUI planetName;
    public TextMeshProUGUI DistanceName;
    public TextMeshProUGUI TimeName;

    private Planet planet;

    public void SetPlanet(Planet planet)
    {
        this.planet = planet;
        planetName.text = planet.GetName();
    }

    public void UpdateValues(Planet currentPlanet)
    {
        if(currentPlanet == planet)
        {
            DistanceName.text = "0 Años luz";
            TimeName.text = "0 Seg";
            return;
        }

        float dist = currentPlanet.DistanceFrom(planet);
        DistanceName.text = dist + " Años luz";
        TimeName.text = dist + " Seg";
    }

    public void SelectPlanet()
    {
        NavegationController.instance.SelectDestination(planet);
    }
}
