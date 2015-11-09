using UnityEngine;
using System.Collections;

public class ball_behavior : MonoBehaviour {
    float horizontalForce = 15f;
    Rigidbody2D ball;
    public game_manager gameMan;

    // Use this for initialization
    void Start () {
        ball = GetComponent<Rigidbody2D>();
        //Randomly picks left or right side to go and add initial force to the ball
        float side = Random.Range(0.0f, 10.0f);
        if (side <= 5.0f)
        {
            ball.AddForce(new Vector2(horizontalForce * 50, 600));
        } else
        {
            ball.AddForce(new Vector2(-horizontalForce * 50, -600));
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Reset the ball location when either side scored
    public void Reset()
    {
        ball.velocity = Vector2.zero;
        transform.position = new Vector2(0, 0);
        Start();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Goal_Left")
        {
            gameMan.GoalScore(2);
            ball.velocity = Vector2.zero;
            if (gameMan.botScore < 3)
            {
                Reset();
            }
        }
        else if (col.gameObject.name == "Goal_Right")
        {
            gameMan.GoalScore(1);
            ball.velocity = Vector2.zero;
            if (gameMan.playerScore < 3)
            {
                Reset();
            }

        }
    }
}
