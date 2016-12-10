﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeShootingScript : MonoBehaviour {

	public Transform projectile;
	public float projectileSpeed = 5000;
	public Transform projectileSpawn;

	private float shootLimit;

	private float lastShoot = 0;
	private bool shot = false;

	// Use this for initialization
	void Start () {
		shootLimit = FindObjectOfType<DudeShootAnimationScript> ().animationDuration;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && (Time.time > lastShoot + shootLimit || !shot)) {
			Transform bullet = Instantiate(projectile, projectileSpawn.position, Camera.main.transform.rotation);
			//bullet.rotation = Quaternion.Euler(bullet.rotation.eulerAngles.x - 90, bullet.rotation.eulerAngles.y, bullet.rotation.eulerAngles.z);
			bullet.GetComponent<Rigidbody>().AddForce (bullet.transform.forward * projectileSpeed);
			Destroy (bullet.gameObject, 2);
			lastShoot = Time.time;
			shot = true;
		}
	}
}
