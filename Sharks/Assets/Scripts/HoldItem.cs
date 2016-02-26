using UnityEngine;
using System.Collections;

public class HoldItem : MonoBehaviour {

	private string item;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			DeployItem ();
		}
	}

	void TakeItem(string item) {
		if (this.item == null) {
			this.item = item;
		}
	}

	void DeployItem() {
		print (string.Format ("Deploying {0}", this.item));
		switch (this.item) {
		case "laser":
			// TODO: Create a laser anchor and laser object
			break;
		default:
			break;
		}
		this.item = null;
	}
}
