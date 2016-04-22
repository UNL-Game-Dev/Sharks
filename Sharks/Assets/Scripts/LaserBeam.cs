using UnityEngine;
using System.Collections;

public class LaserBeam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Target (GameObject target) {
		transform.localRotation = new Quaternion ();
		var relativePosition = transform.InverseTransformVector (target.transform.position);
		transform.Rotate (0, 0, Mathf.Atan2(relativePosition.y, relativePosition.x) * 180 / Mathf.PI - 90);
		transform.localScale = new Vector3 (1.0f, relativePosition.magnitude / 10.0f, 1.0f);
	}
}
