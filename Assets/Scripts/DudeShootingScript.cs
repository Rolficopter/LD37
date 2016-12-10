using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeShootingScript : MonoBehaviour {

	public Transform projectile;
	public float projectileSpeed = 5000;
	public Transform projectileSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Transform bullet = Instantiate(projectile, projectileSpawn.position, projectileSpawn.rotation);
			bullet.GetComponent<Rigidbody>().AddForce (bullet.transform.forward * projectileSpeed);
			Destroy (bullet.gameObject, 2);
		}
	}
}
