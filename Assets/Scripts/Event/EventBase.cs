using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EventBase : MonoBehaviour
{

    protected NavegationController navegationController;

    public virtual void StartEvent(NavegationController navController)
    {
        navegationController = navController;
        StartCoroutine(Event());
    }
    public void EndEvent()
    {
        navegationController.ResumeTravel();
    }

    protected abstract IEnumerator Event();
}
