using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedController : MonoBehaviour
{

    public GameObject selectedGO;
    public Vector3 offset;

    private GameObject selectedCharacter;

    // Start is called before the first frame update
    void Start()
    {
        selectedGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(selectedCharacter != null)
        {
            selectedGO.gameObject.transform.position = selectedCharacter.gameObject.transform.position + offset;
        }
    }

    public void SetSelected(GameObject selected)
    {
        selectedGO.SetActive(true);
        selectedCharacter = selected;
    }

    public void UnsetSelected()
    {
        selectedGO.SetActive(false);
    }
}
