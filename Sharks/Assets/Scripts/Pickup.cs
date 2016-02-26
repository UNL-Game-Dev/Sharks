using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
	public GameObject itemPrefab;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.SendMessage("TakeItem", itemPrefab);
            Destroy(gameObject);
        }
    }
}
