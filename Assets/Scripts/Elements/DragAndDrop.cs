using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool selected;

    public GameObject theController;
    private GameController c;

    // Start is called before the first frame update
    void Start()
    {
        c = theController.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(c.canDrag == true)
        {
            if (c.isDragging == true)
            {
                if (selected == true)
                {
                    Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    transform.position = new Vector2(cursorPos.x, cursorPos.y);
                }

                if (Input.GetMouseButtonUp(0))
                {
                    selected = false;
                }
            }
        }

        
    }

    private void OnMouseOver()
    {
        if (c.isDragging == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                selected = true;
            }
        }
    }


}
