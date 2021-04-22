using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SecretController : MonoBehaviour
{
    public int ctr;
    public bool isDialogue = false;

    public Flowchart _flowchartSecret;

    public GameObject thePlayerController;
    private PlayerController pc;

    public GameObject redDoor;

    public GameObject thePauseController;
    private PauseController pauseConted;

    // Start is called before the first frame update
    void Start()
    {
        _flowchartSecret.GetBooleanVariable("dialogueON");
        _flowchartSecret.GetBooleanVariable("PauseGaming");
        pc = thePlayerController.GetComponent<PlayerController>();
        pauseConted = thePauseController.GetComponent<PauseController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDialogue == true)
        {
            pc.speed = 0;
            pc.jumpForce = 0;

            if(ctr == 1)
            {
                _flowchartSecret.ExecuteBlock("Secret1");
            }
            else if(ctr == 2)
            {
                _flowchartSecret.ExecuteBlock("Secret2");
            }
            else if (ctr == 3)
            {
                _flowchartSecret.ExecuteBlock("Secret3");
            }
            else if (ctr == 4)
            {
                _flowchartSecret.ExecuteBlock("Secret4");
            }
        }

        OffDialogue();

        if(ctr == 4)
        {
            redDoor.gameObject.SetActive(false);
        }

        GameisPaused();
    }

    void OffDialogue()
    {
        if (_flowchartSecret.GetBooleanVariable("dialogueON") == false)
        {
            isDialogue = false;
            pc.speed = 5;
            pc.jumpForce = 6;
            _flowchartSecret.SetBooleanVariable("dialogueON", true);
        }
    }

    void GameisPaused()
    {
        //this prevents the pause mene to show when a dialogue activates
        if (_flowchartSecret.GetBooleanVariable("PauseGaming") == true)
        {
            pauseConted.isPaused = true;
        }
        else
        {
            pauseConted.isPaused = false;
        }
    }
}
