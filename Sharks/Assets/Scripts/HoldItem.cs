using UnityEngine;
using System.Collections;

public class HoldItem : MonoBehaviour {
	
	private GameObject itemPrefab;
	private Vector2 offset;
	private float lifetime;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			DeployItem ();
		}
	}

	void TakeItem(Pickup pickup) {
		if (this.itemPrefab == null) {
			this.itemPrefab = pickup.deployedItem;
		}

		this.offset = pickup.offsetFromPlayer;
		this.lifetime = pickup.lifetimeOnDeploy;
	}

	void DeployItem() {
		if (itemPrefab == null) {
			return;
		}

		print (string.Format ("Deploying {0}", this.itemPrefab.name));
		var ob = Instantiate (itemPrefab, transform.position + transform.TransformVector (offset.x, offset.y, 0f), transform.rotation) as GameObject;
		Destroy (ob, lifetime);
		this.itemPrefab = null;
	}
}
