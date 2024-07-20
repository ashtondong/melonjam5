using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject winnerScreen;   
    
    public void restartGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void winner() {
        winnerScreen.SetActive(true);
        Time.timeScale = 0;
    }
}