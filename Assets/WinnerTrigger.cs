using UnityEngine;

public class WinnerTrigger : MonoBehaviour {
    public GameObject winnerScreen;
    private void OnTriggerEnter2D(Collider2D other) {
        
        // If the player has hit the right wall
        if (other.CompareTag("Player")) {
            
            // Activates the winner screen
            winnerScreen.SetActive(true);

            // Pauses the game
            Time.timeScale = 0;
        }
   }
}