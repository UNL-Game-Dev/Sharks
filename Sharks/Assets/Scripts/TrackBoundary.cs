using UnityEngine;
using System.Collections;

public class TrackBoundary : MonoBehaviour {

	public float barrierHardness;

	public float outerRadius;

	public float innerRadius;

	void FixedUpdate() {
		var distanceFromCenter = gameObject.transform.position.magnitude;

		var rigidBody = GetComponent<Rigidbody2D> ();
		if (distanceFromCenter > outerRadius) {
			rigidBody.AddForce (-gameObject.transform.position.normalized * barrierHardness * (distanceFromCenter - outerRadius));
		}

		if (distanceFromCenter < innerRadius) {
			rigidBody.AddForce (-gameObject.transform.position.normalized * barrierHardness * (innerRadius - distanceFromCenter));
		}
	}
}
