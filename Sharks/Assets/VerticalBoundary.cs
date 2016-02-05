using UnityEngine;
using System.Collections;

public class VerticalBoundary : MonoBehaviour {
	
	void Start () {
		
	}

	void FixedUpdate () {
		var period = 3.0f;
		var a = new Vector3 (0.0f, 2.5f, 0.0f);
		var b = new Vector3 (0.0f, 22.5f, 0.0f);
		var time = Time.timeSinceLevelLoad;
		var t = time % period;
		if (t < period / 2) {
			transform.position = a + (b - a) * t / (period / 2);
		} else {
			transform.position = b + (b - a) * (period / 2 - t) / (period / 2);
		}
	}
}
