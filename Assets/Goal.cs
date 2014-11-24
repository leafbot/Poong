using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	void OnCollisionEnter(Collision pongBall) {
		Destroy(pongBall.gameObject);
		
		Pong.gameOn = false;
		
		if (Pong.score > Pong.bestScore){
			Pong.bestScore = Pong.score;
		}
		
		Pong.score = 0;
	}
		
}
