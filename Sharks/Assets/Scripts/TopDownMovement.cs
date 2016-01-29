using UnityEngine;
using System.Collections;

public class TopDownMovement : MonoBehaviour {

	public float speed;

	public float rotationSpeed;

	public float barrierHardness;

	public float arenaRadius;

	void FixedUpdate() {
		float aimingInput = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().angularVelocity = -rotationSpeed * aimingInput;

		float input = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().AddForce (gameObject.transform.up * speed * input);

		EnforceBoundaries ();
	}

	private void EnforceBoundaries() {
		var distanceFromCenter = gameObject.transform.position.magnitude;

		if (distanceFromCenter > arenaRadius) {
			GetComponent<Rigidbody2D> ().AddForce (-gameObject.transform.position.normalized * barrierHardness * (distanceFromCenter - arenaRadius));
		}
	}
}
