using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodsEvent : EventBase
{

    SpaceShip spaceShip;

    List<SystemBase> systems;

    public override void StartEvent(NavegationController navController)
    {
        spaceShip = SpaceShip.instance;
        systems = spaceShip.GetSystems();

        base.StartEvent(navController);
    }

    protected override IEnumerator Event()
    {
        for(int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("Asteroides: " + i + "/30");

            if(i % 5 == 0)
            {
                if(Random.value > 0.5)
                {
                    systems[Random.Range(0, systems.Count + 1)].TakeDamage(2);
                }
            }
        }

        EndEvent();
    }
}
