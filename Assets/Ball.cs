using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public AudioClip hit;
	
	void OnCollisionEnter(Collision other){
		
		AudioSource.PlayClipAtPoint(hit, rigidbody.velocity);
		
	}

}
