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
		// What direction are we going around the lap?
		var trackDirection = Vector3.Dot(Vector3.Cross(other.transform.position, other.GetComponent<Rigidbody2D>().velocity), new Vector3(0, 0, 1));

		// Only lap if going in the right direction.
		if (trackDirection > 0) {
			other.SendMessage ("AddLap");
		}
	}
}
