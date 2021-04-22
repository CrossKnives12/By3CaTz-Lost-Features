using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePortal : MonoBehaviour
{
    public GameObject theController;
    private GameController c;

    private Vector2 target;
    private Transform LPortal;
    private Transform RPortal;

    // Start is called before the first frame update
    void Start()
    {
        c = theController.GetComponent<GameController>();
        LPortal = GameObject.FindGameObjectWithTag("LeftPortal").GetComponent<Transform>();
        RPortal = GameObject.FindGameObjectWithTag("RightPortal").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Portal();
    }

    /*private void Portal()
    {
        if(c.isPortaling == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                LPortal.position = new Vector2(target.x, target.y);
            }
            else if(Input.GetMouseButtonDown(1))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RPortal.position = new Vector2(target.x, target.y);
            }
        }
    }*/
}
