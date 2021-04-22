using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalEnter : MonoBehaviour
{
    private Transform destination;

    public bool isRight;
    public float distance = 0.3f;

    //public GameObject theController;
    //private GameController c;

    // Start is called before the first frame update
    void Start()
    {
        if(isRight == false)
        {
            destination = GameObject.FindGameObjectWithTag("RightPortal").GetComponent<Transform>();
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("LeftPortal").GetComponent<Transform>();
        }

        //c = theController.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(Vector2.Distance(transform.position, other.transform.position) > distance)
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
    }
}
