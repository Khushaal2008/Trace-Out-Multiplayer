using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Photon.Pun;
using Photon.Realtime;

public class Timer : MonoBehaviour
{
    bool timerActive = false;
    float currentTime;
    public int startMinutes;
    public Text currentTimeText;
    public GameObject GameOverScreen;
    PhotonView PV;

    private void Start()
    {
        currentTime = startMinutes * 60;
        GameOverScreen.SetActive(false);
        PV = GetComponent<PhotonView>();
    }

    private void Update()
    {
        timerActive = true;
        if(timerActive == true)
        {
            currentTime = currentTime - Time.deltaTime;
            if(currentTime <= 0)
            {
                timerActive = false;
                Start();
                Time.timeScale = 0;
                GameOverScreen.SetActive(true);
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    
}