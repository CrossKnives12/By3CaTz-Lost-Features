using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DialogueController : MonoBehaviour
{
    public int diaCount;

    public bool isDialogueScene = false;

    public Flowchart _flowchartScenes;

    public GameObject thePlayerController;
    private PlayerController pc;

    public GameObject thePauseController;
    private PauseController _pauseCont;

    // Start is called before the first frame update
    void Start()
    {
        _flowchartScenes.GetBooleanVariable("resetScene");
        _flowchartScenes.GetBooleanVariable("startGame");
        _flowchartScenes.GetBooleanVariable("PauseGamed");
        pc = thePlayerController.GetComponent<PlayerController>();
        _pauseCont = thePauseController.GetComponent<PauseController>();
    }

    // Update is called once per frame
    void Update()
    {
        OnDialogueScene();

        OffDialogueScene();

        if(_flowchartScenes.GetBooleanVariable("startGame") == true)
        {
            pc.isMoving = true;

            //this prevents the pause menu to show when the game starts after the intro dialogue
            _pauseCont.canPauseGame = true;
        }

        if(_flowchartScenes.GetBooleanVariable("PauseGamed") == false)
        {
            _pauseCont.isPaused = false;
        }
    }

    void OnDialogueScene()
    {
        if (isDialogueScene == true)
        {
            pc.speed = 0;
            pc.jumpForce = 0;

            if (diaCount == 1)
            {
                triggerThePause();
                _flowchartScenes.ExecuteBlock("Cat");
            }
            else if (diaCount == 2)
            {
                _flowchartScenes.ExecuteBlock("SecretPath");
            }
            else if (diaCount == 3)
            {
                _flowchartScenes.ExecuteBlock("Secret");
            }
        }
    }

    void OffDialogueScene()
    {
        if (_flowchartScenes.GetBooleanVariable("resetScene") == false)
        {
            isDialogueScene = false;
            pc.speed = 5;
            pc.jumpForce = 6;
            _flowchartScenes.SetBooleanVariable("resetScene", true);
        }
    }

    void triggerThePause()
    {
        //this prevents the pause mene to show when a dialogue activates
        if (_flowchartScenes.GetBooleanVariable("PauseGamed") == true)
        {
            _pauseCont.isPaused = true;
        }
        else
        {
            _pauseCont.isPaused = false;
        }
    }
}
