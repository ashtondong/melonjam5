using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerTrigger : MonoBehaviour
{
    public GameObject winnerScreen;
    void OnTriggerEnter2D(Collider2D other)
   {
    if (other.CompareTag("Player"))
    {
        winnerScreen.SetActive(true);
        Time.timeScale = 0;
    }
   }
}
