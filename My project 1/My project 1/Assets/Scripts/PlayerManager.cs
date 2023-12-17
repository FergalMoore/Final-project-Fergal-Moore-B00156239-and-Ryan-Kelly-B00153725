using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool onGameStart;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static int coinAmount;
    public TextMeshProUGUI coinText;
    // Initializes game state variables at the start.
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1.0f;
        onGameStart = false;
        coinAmount = 0;
    }
    
    // Pauses the game and activates the "gameOverPanel" when the "gameOver" condition is true.

    void Update()
    {
        if (gameOver)
        {

            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        coinText.text = "Coins: " + coinAmount;

    
        
           
        
        
           
        
    }
}
