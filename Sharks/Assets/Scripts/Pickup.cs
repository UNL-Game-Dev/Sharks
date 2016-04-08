using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
	public GameObject deployedItem;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.SendMessage("TakeItem", deployedItem);
            Destroy(gameObject);
        }
    }
}
