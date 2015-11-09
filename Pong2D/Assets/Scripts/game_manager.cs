using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class game_manager : MonoBehaviour {
    public int playerScore = 0;
    public int botScore = 0;
    public ball_behavior gameBall;
    public Text endGame;

	// Use this for initialization
	void Start () {
        endGame.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoalScore(int playerNumber)
    {
        if(playerNumber == 1)
        {
            playerScore++;
        } else if (playerNumber == 2)
        {
            botScore++;
        }

        if(playerScore == 3)
        {
            GameOver(1);
        } else if (botScore == 3)
        {
            GameOver(2);
        }
    }

    void GameOver(int winner)
    {
        if (playerScore == 3)
        {
            endGame.text = "You Won!";
        } else if (botScore == 3)
        {
            endGame.text = "You LOST!";
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(80, 10, 300, 30), "Player Score: " + playerScore.ToString());
        GUI.Label(new Rect(400, 10, 300, 30), "Enemy Score: " + botScore.ToString());
    }
}
