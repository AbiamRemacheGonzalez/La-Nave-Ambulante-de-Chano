using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AsteriodsEvent : EventBase
{
    SpaceShip spaceShip;

    List<SystemBase> systems;

    public TextMeshProUGUI text;

    public Animator anim;

    public override void StartEvent(NavegationController navController)
    {
        spaceShip = SpaceShip.instance;
        systems = spaceShip.GetSystems();

        base.StartEvent(navController);
    }

    protected override IEnumerator Event()
    {
        DisplayUI();

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

        UnDisplayUI();
        EndEvent();
    }

    public void DisplayUI() {
        text.gameObject.SetActive(true);
        anim.gameObject.SetActive(true);
    }

    public void UnDisplayUI()
    {
        text.gameObject.SetActive(false);
        anim.gameObject.SetActive(false);
    }
}
