using UnityEngine;
using System.Collections;

public class TimeCycle : MonoBehaviour {

	public float sunSpeed = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.y > 0) {		//if daytime, slower
			transform.RotateAround (Vector3.zero, Vector3.right, sunSpeed * Time.deltaTime);
			transform.LookAt (Vector3.zero);
		}
		else {		//if nightime, skip ahead
			transform.RotateAround (Vector3.zero, Vector3.right, 100 * Time.deltaTime);
			transform.LookAt (Vector3.zero);
		}




	}
}
