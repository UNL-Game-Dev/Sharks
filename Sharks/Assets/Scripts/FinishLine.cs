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
		var lapCounter = other.GetComponent<LapCounter> ();
		if (lapCounter != null) {
			lapCounter.AddLap ();
		}
	}
}
