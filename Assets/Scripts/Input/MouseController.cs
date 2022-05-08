using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    private Character selectedCharacter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("RightClick"))
        {
            RaycastHit2D[] hits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            foreach (RaycastHit2D hit in hits)
            {
                if (hit.collider != null)
                {
                    NodeRegion region = hit.collider.gameObject.GetComponent<NodeRegion>();
                    if (region != null && selectedCharacter != null && !selectedCharacter.IsMoving())
                    {
                        foreach (Node n in region.GetNodes())
                        {
                            if (!n.IsOccupied())
                            {
                                selectedCharacter.MoveTo(n);
                                n.SetOccupied(true);
                                break;
                            }
                        }
                    }
                }
            }
        }

        if (Input.GetButtonDown("LeftClick"))
        {
            RaycastHit2D[] hits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            foreach (RaycastHit2D hit in hits)
            {
                if (hit.collider != null)
                {
                    Chano character = hit.collider.gameObject.GetComponent<Chano>();
                    if (character != null)
                    {
                        selectedCharacter = character;
                    }
                }
                else
                {
                    selectedCharacter = null;
                }
            }
        }
    }
}