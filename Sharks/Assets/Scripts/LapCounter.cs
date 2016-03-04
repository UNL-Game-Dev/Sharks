using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class LapCounter : MonoBehaviour {

	private IList<DateTime> laps;

	// Use this for initialization
	void Start () {
		laps = new List<DateTime> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddLap() {
		laps.Add (DateTime.UtcNow);
		print ("Lap " + laps.Count + "!");
	}

    public void RemoveLap()
    {
        if (laps.Count > 0)
        {
            laps.RemoveAt(laps.Count - 1);
        }
    }

	public int Count()
	{
		return laps.Count;
	}
}
