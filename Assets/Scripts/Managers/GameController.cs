using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GameController : MonoBehaviour
{
    #region BOOLEANS
    //ALL BOOLEANS
    //1. Jump
    public bool isJumping = false;
    //2. Drop
    public bool isDropping = false;
    //3. Mouse Visible
    public bool mouseVisible = false;
    //4. Drag
    public bool isDragging = false;
    //5. Timer UI
    public bool isTimerUI = false;
    //6. Quit/Victory UI
    public bool isWinUI = false;

    public bool canDrag = false;

    //===SECRETS===
    //7. Anime Plot Armor
    public bool secret1 = false;
    //8. Power of Friendship
    public bool secret2 = false;
    //9. Wanderer's (something something)
    public bool secret3 = false;
    //10. Weeaboo's Guide to Anime Waifu 101
    public bool secret4 = false;
    #endregion

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Cursors();
    }

    private void Cursors()
    {
        if(mouseVisible == true)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }

        if(Cursor.lockState != CursorLockMode.Confined)
        {
            //Going directly from Locked to Confined does not work
            //Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

}
