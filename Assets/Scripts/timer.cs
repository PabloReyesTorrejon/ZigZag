using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = false;
    public TMP_Text timerText;

    void Start()
    {
        timeIsRunning = true;
        DisplayTime(timeRemaining);
    }

    void Update()
    {
        if(timeIsRunning)
        {
            if(timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void StopTimer() {
        timeIsRunning = false;
    }
}
