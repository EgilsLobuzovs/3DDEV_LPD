using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime == 0)
        {
            //Do nothing
        }

        else
        {
            if (finished)
                return;

            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }
    }

    public void PressStart()
    {
        finished = false;
        timerText.color = Color.white;
        startTime = Time.time;

    }

    public void Finnish()
    {
        finished = true;
        timerText.color = Color.yellow;
    }
}
