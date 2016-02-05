using UnityEngine;
using System.Collections;

public class VerticalBoundary : MonoBehaviour {

	public Vector3 positionA;

	public Vector3 positionB;

	public float period;
	
	void Start () {
		
	}

	void FixedUpdate () {
		var period = 3.0f;
		var time = Time.timeSinceLevelLoad;
		var t = time % period;
		if (t < period / 2) {
			transform.position = positionA + (positionB - positionA) * t / (period / 2);
		} else {
			transform.position = positionB + (positionB - positionA) * (period / 2 - t) / (period / 2);
		}
	}
}
