using UnityEngine;
using System.Collections;

public class Pong : MonoBehaviour {
	
	public static bool gameOn;
	public static int score;
	public static int bestScore;
	public Rigidbody pongBallPrefab;
	public Transform kickOffDirection;
	private float kickOffSpeed = 1000f;
	private int serveAngle;
	
	public AudioClip spawn;

	// Use this for initialization
	void Start () {
		
		gameOn = false;
		score = 0;
		bestScore = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(gameOn == false){
			
			transform.localEulerAngles = new Vector3(0,0,0);
			
			float ballServer = Random.Range(0, 2);
			
			if (ballServer >= 0 && ballServer < 1){
				serveAngle = Random.Range (-55, +55);
			}
			if (ballServer >= 1 && ballServer <= 2){
				serveAngle = Random.Range(125, 235);
			}
			else {
				Debug.Log("Server error");
			}
			
			transform.Rotate(Vector3.up * serveAngle);
			Rigidbody pongBall;
			pongBall = Instantiate(pongBallPrefab, kickOffDirection.position, kickOffDirection.rotation) as Rigidbody;
			pongBall.AddForce(kickOffDirection.forward * kickOffSpeed, ForceMode.Acceleration);
			
			gameOn = true;
			
			AudioSource.PlayClipAtPoint(spawn, pongBall.velocity);
		}
		
	}
	
}
