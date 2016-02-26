using UnityEngine;
using System.Collections;

public class LaserAnchor : MonoBehaviour {

	public GameObject laserBeamPrefab;

	// Use this for initialization
	void Start () {
		print (transform.position);
		Instantiate (laserBeamPrefab, new Vector3 (0, 0, 0), Quaternion.FromToRotation (new Vector3 (0, 0, 0), transform.position));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
