using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcranControleTimer : MonoBehaviour {
	public Text TimerContainer;
	float timeLeft;
	int timerMinutes, timerSeconds, timerMillis;
    public bool stopTime;
    private void Start()
    {
        stopTime = true;
    }
    // Update is called once per frame
    void FixedUpdate () {
        if (!stopTime)
        {
            timeLeft += Time.deltaTime;
            timerMinutes = (int)timeLeft / 60;
            timerSeconds = (int)timeLeft - timerMinutes * 60;
            timerMillis = (int)(timeLeft * 100) - (int)timeLeft * 100;
            TimerContainer.text = "";

            if (timerMinutes < 10)
            {
                TimerContainer.text += "0";
            }
            TimerContainer.text += timerMinutes.ToString() + ":";

            if (timerSeconds < 10)
            {
                TimerContainer.text += "0";
            }
            TimerContainer.text += timerSeconds.ToString() + ":";

            if (timerMillis < 10)
            {
                TimerContainer.text += "0";
            }
            TimerContainer.text += timerMillis.ToString();

        }




    }


    public void ResetTimer()
    {
        timeLeft = 0;
        stopTime = false;
    }

}
