using UnityEngine;
using System.Collections;

public class bot_control : MonoBehaviour {
    public ball_behavior gameBall;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        //The paddle will follow the direction of the ball
        if (gameBall.transform.position.y > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.08f);
        } else if (gameBall.transform.position.y < transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.08f);
        }
    }
}
