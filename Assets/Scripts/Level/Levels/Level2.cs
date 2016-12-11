using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : LevelBehavior {

	public Transform badGuySpawner;

	protected override void LevelStart() {
		var spawner = this.badGuySpawner.GetComponent<BadGuySpawnerLogic> ();
		spawner.StartSpawning ();
	}

	protected override void UpdateLevel() {

	}
}
