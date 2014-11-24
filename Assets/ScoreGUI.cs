using UnityEngine;
using System.Collections;

public class ScoreGUI : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
			guiText.text = Pong.score.ToString();
	
	}
}
