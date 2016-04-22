using UnityEngine;
using System.Collections;

public class PowerupSpawn : MonoBehaviour
{
    public Rigidbody2D[] Pickups;
    public float spawnTime = 3f;


	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}


    void Spawn()
    {
        var angle = Random.Range(0, 2 * Mathf.PI);
        var Pickup = Pickups[Random.Range(0, Pickups.Length)];
        Rigidbody2D Projectile = (Rigidbody2D)Instantiate(Pickup, transform.position, transform.rotation);
        Projectile.velocity = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * 10;
	}
    
	
	
}
