using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{

    public EventBase[] events;

    public void StartEvent(NavegationController navController)
    {
        events[Random.Range(0, events.Length)].StartEvent(navController);
    }
}
