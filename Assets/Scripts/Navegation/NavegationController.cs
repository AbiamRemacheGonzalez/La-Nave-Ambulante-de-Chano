using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavegationController : MonoBehaviour
{
    public static NavegationController instance;

    public EventsManager eventsManager;

    public GameObject navUI;

    public Animator anim;

    private Planet currentPlanet;
    private Planet destination;

    private bool isTraveling = false;

    private bool eventIsOn = false;
    private bool thereWasEvent = false;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsTraveling()
    {
        return isTraveling;
    }

    public void SetCurrentPlanet(Planet planet)
    {
        currentPlanet = planet;
    }

    public Planet GetCurrentPlanet()
    {
        return currentPlanet;
    }

    public void SelectDestination(Planet dest)
    {
        if(currentPlanet.DistanceFrom(dest) / 10 > SpaceShip.instance.GetFuel())
        {
            return;
        }
        SpaceShip.instance.RemoveFuel(currentPlanet.DistanceFrom(dest) / 10);
        destination = dest;
        navUI.SetActive(false);
        StartCoroutine(Travel());
    }

    private IEnumerator Travel()
    {
        isTraveling = true;
        float distance = currentPlanet.DistanceFrom(destination);

        anim.SetBool("isTravelling", true);

        float quarter = distance / 4;
        thereWasEvent = false;

        for (int i = 1; i <= distance; i++)
        {
            yield return new WaitForSeconds(1);
            Debug.Log(i + "/" + distance);
            if(!thereWasEvent && i % quarter == 0)
            {
                if (Random.value > 0.75f)
                {
                    anim.SetBool("isTravelling", false);
                    eventsManager.StartEvent(this);
                    eventIsOn = true;
                    while (eventIsOn)
                    {
                        yield return null;
                    }
                    thereWasEvent = true;
                    anim.SetBool("isTravelling", true);
                }
            }
        }

        anim.SetBool("isTravelling", false);

        SetCurrentPlanet(destination);
        isTraveling = false;
    }

    public void ResumeTravel()
    {
        eventIsOn = false;
    }

}
