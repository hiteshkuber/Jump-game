using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    private int playerScore;
    public Text scoreText;
    public GameObject gameObject;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
    
    public void restartGame()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameObject.SetActive(true);
    }
}
