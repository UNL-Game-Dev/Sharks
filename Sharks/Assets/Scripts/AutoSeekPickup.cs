using UnityEngine;
using System.Collections;
using System.Linq;

public class AutoSeekPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// TODO: Make the AI seek pickups. Does nothing for now, which is fine
//		var targetPickupObject = Object.FindObjectsOfType (Pickup)
//			.Select (o => (o as Pickup).gameObject)
//			.Where (p => Vector3.Angle(p.transform.position - transform.position, Vector3.up) <= 60)
//			.Min (p => Vector3.Distance(transform.position, p.transform.position));
	}
}
