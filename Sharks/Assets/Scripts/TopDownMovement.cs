using UnityEngine;
using System.Collections;

public class TopDownMovement : MonoBehaviour {

	public float speed;

	public float rotationSpeed;

	void FixedUpdate() {
		float aimingInput = Input.GetAxis ("Horizontal");
		var currentSpeed = GetComponent<Rigidbody2D> ().velocity.magnitude;
		GetComponent<Rigidbody2D>().angularVelocity = -rotationSpeed * aimingInput * currentSpeed / speed;

		float input = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().AddForce (gameObject.transform.up * speed * input);
	}
}
