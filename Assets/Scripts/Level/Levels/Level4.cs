using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4 : LevelBehavior {

	public Transform badGuySpawner;

	protected override void LevelStart() {
		var spawner = this.badGuySpawner.GetComponent<BadGuySpawnerLogic> ();
		spawner.StartSpawning ();
		GetComponent<AudioSource> ().Play ();
	}

	protected override void UpdateLevel() {

	}
}
