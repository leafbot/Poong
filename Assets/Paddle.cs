using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
		
	private float paddleSpeed = 50f;
	private float reflectAmp = 3f;

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(-Vector3.right * paddleSpeed * Time.deltaTime, Space.World);
		
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(Vector3.right * paddleSpeed * Time.deltaTime, Space.World);
		
		if (Input.GetKeyDown(KeyCode.RightArrow))
			transform.Rotate(Vector3.up * 45, Space.World);
		
		if (Input.GetKeyUp(KeyCode.RightArrow))
			transform.Rotate(Vector3.up * -45, Space.World);
		
		if (Input.GetKeyDown(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up * -45, Space.World);
		
		if (Input.GetKeyUp(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up * 45, Space.World);
		
		// Touchscreen controls:
		
		if (Input.touchCount == 1){
		
			Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
			RaycastHit hitInfo;
			
			int layer1 = 1 << 9;
			
			if (Physics.Raycast (ray, out hitInfo, Mathf.Infinity, layer1))
				transform.position = Vector3.MoveTowards(transform.position, new Vector3(hitInfo.point.x, transform.position.y, transform.position.z), paddleSpeed * Time.deltaTime);
				Debug.Log ("Mouse: " + Input.mousePosition);
				Debug.Log ("Camera: " + hitInfo.point);
				Debug.Log ("Collider: " + hitInfo.collider);
				Debug.Log ("Distance: " + hitInfo.distance);
			
		}
	}
	
	void OnCollisionEnter(Collision other){
		
		Pong.score++;
		other.rigidbody.AddForce(other.rigidbody.velocity * reflectAmp, ForceMode.Acceleration);
	}
}
