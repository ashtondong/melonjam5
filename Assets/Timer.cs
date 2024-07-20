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
    // Default start value is 30 seconds
    public int startValue = 30;
    public TMP_Text currentValueText;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = startValue;
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
            }

            TimeSpan time = TimeSpan.FromSeconds(currentValue);
            currentValueText.text = time.ToString(@"ss\:ff");
        }
    }

    public void StartTimer() {
        timerActive = true;
    }

    public void StopTimer() {
        timerActive = false;
    }   
}