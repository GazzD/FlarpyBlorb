using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int playerScore = 0;
    public TMP_Text scoreLabel;
    public GameObject gameOverPanel;
    public static GameManager Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        //if (Instance != null)
        //{
        //    Destroy(gameObject);
        //}
        //else
        //{
        //Instance = this;
        //    DontDestroyOnLoad(gameObject);
        //}
    }

    [ContextMenu("Increase Score")]
    public void IncreaseScore()
    {
        IncreaseScore(1);
    }

    private void IncreaseScore(int addedScore)
    {
        playerScore += addedScore;
        scoreLabel.text = playerScore.ToString();
    }

    public void ResetScore()
    {
        playerScore = 0;
        scoreLabel.text = playerScore.ToString();
    }

    public void ResetGame()
    {
        ResetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
}
