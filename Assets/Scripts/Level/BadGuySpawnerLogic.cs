using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuySpawnerLogic : MonoBehaviour {

	public bool endless = false;
	[Range(1, 100)]
	public int numberOfBadGuys = 1;
	[Range(0.01f, 60.0f)]
	public float spawnInterval = 1.0f;
	public Transform badGuy;

	private float lastSpawnTime;

	// Use this for initialization
	void Start () {
		this.lastSpawnTime = Time.time;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!this.endless && this.numberOfBadGuys == 0) {
			return;
		}

		Debug.LogFormat("Last spawn time: {0}, current time: {1}", this.lastSpawnTime, Time.time);
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
}
