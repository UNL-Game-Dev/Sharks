using UnityEngine;
using System.Collections;

public class LaserAnchor : MonoBehaviour {

	public GameObject laserBeamPrefab;

	// Use this for initialization
	void Start () {;
		print (transform.position);
		var laserBeamObject = Instantiate (laserBeamPrefab, new Vector3 (0, 0, 0), new Quaternion ()) as GameObject;
		laserBeamObject.transform.parent = transform;
		var laserBeam = laserBeamObject.GetComponent<LaserBeam> ();
		laserBeam.Target (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
