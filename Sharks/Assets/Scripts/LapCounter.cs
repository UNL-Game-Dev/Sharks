using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;

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

	public TimeSpan? GetFastestLap()
	{
		TimeSpan? fastestLap = null;
		for (var i = 0; i < laps.Count - 1; i++)
		{
			var thisLapTime = laps.ElementAt (i + 1) - laps.ElementAt (i);
			if (fastestLap == null || thisLapTime < fastestLap)
			{
				fastestLap = thisLapTime;
			}
		}

		return fastestLap;
	}

	public TimeSpan? GetSlowestLap()
	{
		TimeSpan? slowestLap = null;
		for (var i = 0; i < laps.Count - 1; i++)
		{
			var thisLapTime = laps.ElementAt (i + 1) - laps.ElementAt (i);
			if (slowestLap == null || thisLapTime > slowestLap)
			{
				slowestLap = thisLapTime;
			}
		}

		return slowestLap;
	}

	public TimeSpan? GetAverageLap()
	{
		if (laps.Count () <= 1) {
			return null;
		}

		return new TimeSpan((laps.Last () - laps.First ()).Ticks / (laps.Count () - 1));
	}
}
