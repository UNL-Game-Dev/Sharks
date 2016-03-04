using UnityEngine;
using System.Collections;

public class LaserAnchor : MonoBehaviour {

	public GameObject laserBeamPrefab;

	// Use this for initialization
	void Start () {
		print (transform.position);
		var laserBeam = (Instantiate (laserBeamPrefab, new Vector3 (0, 0, 0), new Quaternion()) as GameObject).GetComponent<LaserBeam> ();
		laserBeam.Target (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
