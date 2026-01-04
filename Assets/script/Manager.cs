using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject levelComplete;
    bool gameHasEnded = false;

    void Start()
    {
        // Hide panel at game start
        levelComplete.SetActive(false);
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME IS OVER");
            levelComplete.SetActive(true);
            Time.timeScale = 0f; // Pause game
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    internal void completeLevel()
    {
        throw new NotImplementedException();
    }
}
