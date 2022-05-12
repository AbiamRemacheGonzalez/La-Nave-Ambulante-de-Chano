using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject objectToClose;
    [SerializeField]
    private Animator anim;

    private void Start()
    {
        anim = GameObject.Find("Espacio").GetComponent<Animator>();
    }

    public void ClickTravel() {
        anim.SetBool("isTravelling", true);
        objectToClose.SetActive(false);
    }
}
