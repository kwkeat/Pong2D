using UnityEngine;
using System.Collections;

public class movements_control : MonoBehaviour {
    float paddleSpeed = 0.2f;
    Transform playerTransform;

	// Use this for initialization
	void Start () {
        playerTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up"))
        {
            playerTransform.position = new Vector2(playerTransform.position.x, playerTransform.position.y + paddleSpeed);
        } else if (Input.GetKey("down"))
        {
            playerTransform.position = new Vector2(playerTransform.position.x, playerTransform.position.y - paddleSpeed);
        }
    }
}
