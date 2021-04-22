using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;

    private float timed;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timed = Time.time - startTime;

        string minutes = ((int)timed / 60).ToString();
        string seconds = (timed % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
}
