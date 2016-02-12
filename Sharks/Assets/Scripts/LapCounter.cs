using UnityEngine;
using System.Collections;
using System;

public class LapCounter : MonoBehaviour {

	private IList<DateTime> laps;

	// Use this for initialization
	void Start () {
		laps = new ArrayList<DateTime> {
			DateTime.UtcNow
		};
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddLap() {
		laps.Add (new DateTime(DateTime.UtcNow));
		print ("Lap " + currentLap + "!");
	}
}
