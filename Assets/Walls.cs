using UnityEngine;
using System.Collections;

public class Walls : MonoBehaviour {
	
	private float reflectAmp = 3f;
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other){
		
		other.rigidbody.AddForce(other.rigidbody.velocity * reflectAmp, ForceMode.Acceleration);
		
	}
}
