using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool birdAlive = true;
    public AudioSource yessir;

    [ContextMenu("Increase Score")] // will show in the unity log script under the 3 dots
    public void incScore(int scoreToAdd)
    {
        if (birdAlive == true)
        {
            score += scoreToAdd;
            scoreText.text = score.ToString();
            Debug.Log("Score Increased!");
            yessir.Play();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Game has Restarted!");
        birdAlive = true;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Debug.Log("Game has Ended!");
        birdAlive = false;
    }
}
