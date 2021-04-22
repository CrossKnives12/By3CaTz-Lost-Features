using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTrigger : MonoBehaviour
{
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
        
    }

    private void OnTriggerEnter2D(Collider2D colEnter)
    {
        if (colEnter.CompareTag("Player"))
        {
            c.isDragging = true;
        }
    }

    private void OnTriggerStay2D(Collider2D colStay)
    {
        if (colStay.CompareTag("Player"))
        {
            c.isDragging = true;
        }
    }

    private void OnTriggerExit2D(Collider2D colExit)
    {
        if (colExit.CompareTag("Player"))
        {
            c.isDragging = false;
        }
    }
}
