using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuySpawnerLogic : MonoBehaviour {

	public bool endless = false;
	public bool isSpawning = true;

	[Range(1, 100)]
	public int numberOfBadGuys = 1;
	[Range(0.01f, 60.0f)]
	public float spawnInterval = 1.0f;
	public Transform badGuy;

	private float lastSpawnTime;

	// Use this for initialization
	void Start () {
		this.lastSpawnTime = float.MinValue;

		if (this.badGuy == null) {
			Debug.LogError ("Unassigned bad guy to spawn.");
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!this.isSpawning) {
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
		this.isSpawning = true;
	}
	public void StopSpawning() {
		this.isSpawning = false;
	}
}
