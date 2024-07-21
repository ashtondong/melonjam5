using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    bool timerActive = false;
    float currentValue;
    // Timer set for 20 seconds
    public int startValue = 20;
    public TMP_Text currentValueText;
    public PlayerMovement playerMovement;
    public GameEnd gameEnd;

    // Initial display
    void Start() {
        currentValue = startValue;
        currentValueText.text = currentValue.ToString("0");
    }

    // Update per frame
    private void Update() {
        if (playerMovement != null && playerMovement.body.velocity != Vector2.zero && !timerActive) {
            StartTimer();
        }

        // Decrement timer by second
        if (timerActive) {
            currentValue = currentValue - Time.deltaTime;

            // End game when timer hits 0
            if (currentValue <= 0) {
                currentValue = 0;
                StopTimer();
                GameOver();
            }

            // Update timer display 
            currentValueText.text = Mathf.CeilToInt(currentValue).ToString();
        }
    }

    public void StartTimer() {
        timerActive = true;
    }

    public void StopTimer() {
        timerActive = false;
    }

    void GameOver() {
        gameEnd.gameOver();
    }
}