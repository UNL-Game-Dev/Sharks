using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

[RequireComponent (typeof(Text))]
public class LapDisplay : MonoBehaviour {

	public GameObject lapCounterObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var lapCounter = lapCounterObject.GetComponent<LapCounter> ();
		var lapCount = lapCounter.Count ();
		var text = GetComponent<Text> ();
		text.text = "Lap " + lapCount;
	}
}
