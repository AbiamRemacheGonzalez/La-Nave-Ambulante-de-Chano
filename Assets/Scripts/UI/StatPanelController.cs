using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatPanelController : MonoBehaviour
{
    public GameObject statPanel;
    
    public Slider engineering;
    public Slider piloting;
    public Slider repairing;
    public Slider shooting;

    public void Configure(Chano character) {
        statPanel.SetActive(true);
        Stats stats = character.GetStats();
        engineering.value = stats.GetEngineering() / 100;
        piloting.value = stats.GetPiloting() / 100;
        repairing.value = stats.GetRepairing() / 100;
        shooting.value = stats.GetShooting() / 100;
    }

    public void TurnOff() {
        statPanel.SetActive(false);
    }
}
