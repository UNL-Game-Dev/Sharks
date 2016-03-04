using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class LapDisplay : MonoBehaviour {

	public GameObject lapCounterObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var lapCount = lapCounterObject.GetComponent<LapCounter> ().Count ();
		GetComponent<Text> ().text = string.Format ("Laps: {0}", lapCount);
	}
}
