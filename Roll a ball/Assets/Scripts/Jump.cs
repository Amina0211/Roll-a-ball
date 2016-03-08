using UnityEngine;
using System.Collections;


public class Jump : MonoBehaviour {
	public float thrust;
	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		if (Input.GetButtonDown ("Jump")) {
			Vector3 vector = new Vector3 (0.0f, 1.0f, 0.0f);
			rb.AddForce (vector * thrust);
		}
	}
}