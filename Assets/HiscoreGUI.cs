using UnityEngine;
using System.Collections;

public class HiscoreGUI : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
			guiText.text = "Best Score: " + Pong.bestScore.ToString();
	
	}
}
