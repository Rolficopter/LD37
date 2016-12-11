using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuySpawnerLogic : MonoBehaviour {

	public bool endless = false;
	public bool startAutomatically = true;

	[Range(1, 100)]
	public int numberOfBadGuys = 1;
	[Range(0.01f, 60.0f)]
	public float spawnInterval = 1.0f;
	public Transform badGuy;

	private bool isRunning = false;
	private float lastSpawnTime;

	// Use this for initialization
	void Start () {
		this.lastSpawnTime = Time.time;

		if (this.startAutomatically) {
			this.StartSpawning ();
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!this.isRunning) {
			return;
		}

		if (!this.endless && this.numberOfBadGuys == 0) {
			return;
		}

		if (this.lastSpawnTime + this.spawnInterval <= Time.time) {
			this.SpawnBadGuys ();
		}
	}

	private void SpawnBadGuys() {
		Instantiate (this.badGuy, this.transform.position, this.transform.rotation);

		this.lastSpawnTime = Time.time;
		if (!this.endless) {
			this.numberOfBadGuys--;
		}
	}

	public void StartSpawning() {
		this.isRunning = true;
	}
	public void StopSpawning() {
		this.isRunning = false;
	}
}
