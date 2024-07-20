using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    bool timerActive = false;
    float currentValue;
    // Default start value is 5 seconds
    public int startValue = 5;
    public TMP_Text currentValueText;
    public PlayerMovement playerMovement;
    public GameEnd gameEnd;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = startValue;
        currentValueText.text = currentValue.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement != null && playerMovement.body.velocity != Vector2.zero && !timerActive) {
            StartTimer();
        }

        if (timerActive) {
            currentValue = currentValue - Time.deltaTime;

            if (currentValue <= 0) {
                currentValue = 0;
                StopTimer();
                GameOver();
            }

            currentValueText.text = Mathf.CeilToInt(currentValue).ToString();
        }
    }

    public void StartTimer() {
        timerActive = true;
    }

    public void StopTimer() {
        timerActive = false;
    }

    void GameOver()
    {
        gameEnd.gameOver();
    }
}