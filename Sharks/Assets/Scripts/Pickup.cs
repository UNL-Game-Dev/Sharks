using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.SendMessage("TakeItem", "laser");
            Destroy(gameObject);
        }

    }
}
