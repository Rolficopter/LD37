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
			Transform bullet = Instantiate(projectile, projectileSpawn.position, Camera.main.transform.rotation);
			//bullet.rotation = Quaternion.Euler(bullet.rotation.eulerAngles.x - 90, bullet.rotation.eulerAngles.y, bullet.rotation.eulerAngles.z);
			bullet.GetComponent<Rigidbody>().AddForce (bullet.transform.forward * projectileSpeed);
			Destroy (bullet.gameObject, 2);
		}
	}
}
