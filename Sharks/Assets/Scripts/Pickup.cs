using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
	public GameObject deployedItem;
	public Vector2 offsetFromPlayer = new Vector2 (0f, 0f);
	public float lifetimeOnDeploy = 2.0f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
			other.SendMessage("TakeItem", this);
            Destroy(gameObject);
        }
    }
}
