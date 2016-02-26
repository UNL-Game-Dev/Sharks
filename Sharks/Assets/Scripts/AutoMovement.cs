using UnityEngine;
using System.Collections;

/**
 * AutoMovement works like TopDownMovement, except that the inputs are determined by the game, not the player.
 * A shark with AutoMovement will try to travel counter-clockwise around the track.
 */
public class AutoMovement : MonoBehaviour {

	public float speed;
	public float rotationSpeed;
	public float targetRadius;		// shark will try to stay within this radius

	void FixedUpdate() {

		// always move forward
		float input = 1;

		// calculate distance from center
		float px = gameObject.transform.position.x;
		float py = gameObject.transform.position.y;
		float distance = Mathf.Sqrt((px * px) + (py * py));
		

		float aimingInput;											// whether to turn left or right
		float angle = gameObject.transform.eulerAngles.z;			// current angle of the shark
		float targetAngle = Mathf.Atan2(py, px) * 180 / Mathf.PI;	// desired angle: tangent to the circular path
		float oppositeAngle;										// used to compare angles

		if (targetAngle < 0) targetAngle += 360;		// adjust for negative angles returned by Mathf.Atan2()
		if(distance > targetRadius) targetAngle += 45;	// if too far away, cut in toward the center
		oppositeAngle = targetAngle + 180;				// 180 degrees from the target angle
		if(targetAngle >= 360) targetAngle -= 360;		// keep angles within 0 to 360
		if(oppositeAngle >= 360) oppositeAngle -= 360;

		if (!compareAngles(angle, targetAngle) && compareAngles(angle, oppositeAngle)) {
			// want to turn right
			aimingInput = 1;
		} else {
			// want to turn left
			aimingInput = -1;
		}

		// apply inputs
		var currentSpeed = GetComponent<Rigidbody2D>().velocity.magnitude;
		GetComponent<Rigidbody2D>().angularVelocity = -rotationSpeed * aimingInput * currentSpeed / speed;
		GetComponent<Rigidbody2D>().AddForce (gameObject.transform.up * speed * input);
	}

	/* Compares two angles to determine which one is larger.
	 * The larger angle is the one that is no more than 180 degrees counter-clockwise from the other on the unit circle.
	 * For example, if a=30 and b=330, a is considered larger, because a is less than 180 degrees counter-clockwise from b.
	 * This function assumes a and b are angles in degrees on the interval [0,360].
	 * Returns true if a <= b, false otherwise.
	 */
	bool compareAngles(float a, float b) {

		// changing 0 to 360 makes the logic easier
		if (a == 0) a = 360;
		if (b == 0) b = 360;

		if (b >= 180 ) {
			return a > b - 180 && a <= b;
		} else {
			return (a > b + 180 && a <= 360) || (a >= 0 && a <= b);
		}
	}
}
