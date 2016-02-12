using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		// Math.
		var trackVelocity = Vector3.Dot(Vector3.Cross(other.transform.position, other.GetComponent<Rigidbody2D>().velocity), new Vector3(0, 0, 1));

		// Only lap if going in the right direction.
		if (trackVelocity > 0) {
			var lapCounter = other.GetComponent<LapCounter> ();
			if (lapCounter != null) {
				lapCounter.AddLap ();
			}
		}
	}
}
