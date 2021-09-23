using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    int totalScore = 0;
    int totalCoin = 0;
    int evolveBonus = 0;
    int totalFirePoint = 0;
    int totalWaterPoint= 0;
    int totalElecPoint= 0;
    float timeLimit = 60.0f;
    public Text coinText;
    public Text scoreText;
    public Text timeText;
    public Text firePointText;
    public Text waterPointText;
    public Text elecPointText;
    public GameObject TimeOverPanel;
    public GameObject RetryPanel;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        initGame();
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;
       
        if (timeLimit < 0)
        {
            GameObject.Find("Player").GetComponent<Player>().enabled = false;
            Time.timeScale = 0.0f;
            timeLimit = 0.0f;
            TimeOverPanel.SetActive(true);

        }
        timeText.text = timeLimit.ToString("N0");
    }

    void initGame()
    {
        Time.timeScale = 1.0f;
        totalScore = 0;
        timeLimit = 10.0f;
    }
    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
        totalCoin = totalScore * 1 + evolveBonus;
        coinText.text = totalCoin.ToString();
        
    }

    public void addFirePoint(int firePoint)
    {
        totalFirePoint += firePoint;
        firePointText.text = totalFirePoint.ToString();
    }

    public void addWaterPoint(int waterPoint)
    {
        totalWaterPoint += waterPoint;
        waterPointText.text = totalWaterPoint.ToString();
    }
    public void addElecPoint(int elecPoint)
    {
        totalElecPoint += elecPoint;
        elecPointText.text = totalElecPoint.ToString();
    }


    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}


