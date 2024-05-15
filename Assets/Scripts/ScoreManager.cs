using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public PlayerStats playerStats;

    void Start()
    {
        // resets the score to 0 at the start of the game
        score = 0;
		//playerStats = GetComponent<PlayerStats>();
	}
     public void AddHealth()
    {
        if (score % 100 == 0)
        {
            Debug.Log(score);
            if(playerStats.health <= playerStats.playerStartingHealth - 1)
            {
                playerStats.health++;
				playerStats.UpdateHealthUI();
				Debug.Log(playerStats.health);
            }
        }
    }
}