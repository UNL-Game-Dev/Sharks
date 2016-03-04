using UnityEngine;
using System.Collections;

public class LaserAnchor : MonoBehaviour {

	public GameObject laserBeamPrefab;

	public float delay = 2.0f;

	// Use this for initialization
	void Start () {;
		print (transform.position);
		var laserBeamObject = Instantiate (laserBeamPrefab, new Vector3 (0, 0, 0), new Quaternion ()) as GameObject;
		var laserBeam = laserBeamObject.GetComponent<LaserBeam> ();
		laserBeam.Target (gameObject);
		Destroy (laserBeamObject, delay);
		Destroy (gameObject, delay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
