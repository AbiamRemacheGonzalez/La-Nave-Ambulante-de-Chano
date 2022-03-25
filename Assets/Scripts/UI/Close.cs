using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject objectToClose;
    public void ClickClose() {
        objectToClose.SetActive(false);
    }
}
