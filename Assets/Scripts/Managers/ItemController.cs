using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ItemController : MonoBehaviour
{
    public int itemCount;
    public int dataCount;
    public bool isDialogueData = false;
    public bool isDialogueAbilities = false;

    public Flowchart _flowchartData;
    public Flowchart _flowchartAbilities;

    public GameObject thePlayerController;
    private PlayerController pc;

    public GameObject theTimer;

    public GameObject theController;
    private GameController c;

    public GameObject thePauseController;
    private PauseController pauseCont;

    // Start is called before the first frame update
    void Start()
    {
        _flowchartData.GetBooleanVariable("resetData");
        _flowchartAbilities.GetBooleanVariable("resetAbilities");
        _flowchartData.GetBooleanVariable("PauseGame");
        _flowchartAbilities.GetBooleanVariable("PauseGame");
        pc = thePlayerController.GetComponent<PlayerController>();
        c = theController.GetComponent<GameController>();
        pauseCont = thePauseController.GetComponent<PauseController>();
    }

    // Update is called once per frame
    void Update()
    {
        OnDialogueData();
        OnDialogueAbilities();

        OffDialogueData();
        OffDialogueAbilities();

        if(dataCount == 3)
        {
            theTimer.gameObject.SetActive(true);
        }

        AbilityList();

        DataPauseMenu();
        AbilityPauseMenu();
    }

    void AbilityList()
    {
        if(itemCount == 1)
        {
            c.isJumping = true;
        }

        if (itemCount == 2)
        {
            c.isDropping = true;
        }

        if (itemCount == 3)
        {
            c.canDrag = true;
            c.mouseVisible = true;
        }

        if (itemCount == 4)
        {
            pc.extraJumpsValue = 1;
        }
    }


    void OnDialogueData()
    {
        if (isDialogueData == true)
        {
            pc.speed = 0;
            pc.jumpForce = 0;

            if (dataCount == 1)
            {
                _flowchartData.ExecuteBlock("Data1");
            }
            else if (dataCount == 2)
            {
                _flowchartData.ExecuteBlock("Data2");
            }
            else if (dataCount == 3)
            {
                _flowchartData.ExecuteBlock("Data3");
            }
            else if (dataCount == 4)
            {
                _flowchartData.ExecuteBlock("Data4");
            }
        }
    }

    void OnDialogueAbilities()
    {
        if (isDialogueAbilities == true)
        {
            pc.speed = 0;
            pc.jumpForce = 0;

            if (itemCount == 1)
            {
                _flowchartAbilities.ExecuteBlock("Ability1");
            }
            else if (itemCount == 2)
            {
                _flowchartAbilities.ExecuteBlock("Ability2");
            }
            else if (itemCount == 3)
            {
                _flowchartAbilities.ExecuteBlock("Ability3");
            }
            else if (itemCount == 4)
            {
                _flowchartAbilities.ExecuteBlock("Ability4");
            }
        }
    }

    void OffDialogueData()
    {
        if (_flowchartData.GetBooleanVariable("resetData") == false)
        {
            isDialogueData = false;
            pc.speed = 5;
            pc.jumpForce = 6;
            _flowchartData.SetBooleanVariable("resetData", true);
        }
    }

    void OffDialogueAbilities()
    {
        if (_flowchartAbilities.GetBooleanVariable("resetAbilities") == false)
        {
            isDialogueAbilities = false;
            pc.speed = 5;
            pc.jumpForce = 6;
            _flowchartAbilities.SetBooleanVariable("resetAbilities", true);
        }
    }

    void DataPauseMenu()
    {
        if (_flowchartData.GetBooleanVariable("PauseGame") == true)
        {
            pauseCont.isPaused = true;
        }
        else
        {
            pauseCont.isPaused = false;
        }
    }

    void AbilityPauseMenu()
    {
        if (_flowchartAbilities.GetBooleanVariable("PauseGame") == true)
        {
            pauseCont.isPaused = true;
        }
        else
        {
            pauseCont.isPaused = false;
        }
    }
}
