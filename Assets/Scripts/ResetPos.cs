using UnityEngine;
using System.Collections;

public class ResetPos : MonoBehaviour {

	private Vector3 originalPosition;

	// Use this for initialization
	void Start () {
		originalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -20) {
			transform.position = originalPosition;
		}
	}
}
