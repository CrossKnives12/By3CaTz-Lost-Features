using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject panelUI;

    public GameObject theController;
    private GameController c;

    public bool isPaused;
    public bool canPauseGame;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        canPauseGame = false;
        c = theController.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canPauseGame == true)
        {
            if(isPaused == false)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Cursor.visible = true;
                    panelUI.gameObject.SetActive(true);
                    Time.timeScale = 0;
                    isPaused = true;
                }
            }
        }
    }

    public void ResumeGame()
    {
        panelUI.gameObject.SetActive(false); ;
        Time.timeScale = 1;

        if(c.mouseVisible == false)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
        isPaused = false;
    }
}
