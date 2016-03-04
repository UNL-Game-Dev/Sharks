using UnityEngine;
using System.Collections;

public class HoldItem : MonoBehaviour {
	
	private GameObject itemPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			DeployItem ();
		}
	}

	void TakeItem(GameObject itemPrefab) {
		if (this.itemPrefab == null) {
			this.itemPrefab = itemPrefab;
		}
	}

	void DeployItem() {
		if (itemPrefab == null) {
			return;
		}

		print (string.Format ("Deploying {0}", this.itemPrefab.name));
		Instantiate (itemPrefab, transform.position, transform.rotation);
		this.itemPrefab = null;
	}
}
