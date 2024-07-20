using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {
    public GameObject gameOverScreen;
    public GameObject winnerScreen;   

    // Restarts game    
    public void restartGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Display game over screen
    public void gameOver() {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    // Display winner screen
    public void winner() {
        winnerScreen.SetActive(true);
        Time.timeScale = 0;
    }
}