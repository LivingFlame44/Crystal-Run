using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int score = 0;
    public GameObject GameOverPanel;
    public GameObject currentScore;
    public GameObject currentScoreUI;
    public GameObject highScoreGame;
    public GameObject highScoreMenu;
    public GameObject highScoreGameOver;
    public GameObject gamePanel;
    // Start is called before the first frame update
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        currentScore.gameObject.GetComponent<TextMeshProUGUI>().text = score.ToString();
        highScoreGame.gameObject.GetComponent<TextMeshProUGUI>().text = "Best: " + PlayerPrefs.GetInt("highscore", 0).ToString();
        highScoreGameOver.gameObject.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("highscore", 0).ToString();
        highScoreMenu.gameObject.GetComponent<TextMeshProUGUI>().text = "Best: " + PlayerPrefs.GetInt("highscore", 0).ToString();
    }

    public void GameOver()
    {
        if (score > PlayerPrefs.GetInt("highscore",0))
        {
            PlayerPrefs.SetInt("highscore", score);
            PlayerPrefs.Save();
        }
        currentScoreUI.gameObject.GetComponent<TextMeshProUGUI>().text = score.ToString();
        GameOverPanel.SetActive(true);
        gamePanel.SetActive(false);
        Time.timeScale = 0f;
    }

    public void UpdateScore()
    {
        score = score + 1;
    }
}
