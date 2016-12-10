using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLevelManager : MonoBehaviour {

	public int numberOfLevels;

	private int currentLevel;

	// Use this for initialization
	void Start () {
		this.SetCurrentLevel (0);

		if (this.numberOfLevels < 1) {
			Debug.LogError ("Number of levels is lower than 1!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	#region Changing the level
	/// <summary>
	/// Gos to next level.
	/// </summary>
	public void GoToNextLevel() {
		if ( this.GetCurrentLevel() == this.numberOfLevels) {
			Debug.Log ("You won!");
		} else {
			
			if (!this.SetCurrentLevel (this.currentLevel + 1)) {
				return;
			}
				
			var objectsToRemove = GameObject.FindGameObjectsWithTag ("RemoveFor_Level" + this.GetCurrentLevel());
			foreach(var obj in objectsToRemove)
			{
				// TODO: animate here
				DestroyObject(obj);
			}
		}
	}
		
	/// <summary>
	/// Sets the current level.
	/// </summary>
	/// <returns><c>true</c>, if current level was set, <c>false</c> otherwise.</returns>
	/// <param name="level">Level.</param>
	public bool SetCurrentLevel(int level) {
		if (level < 0 || level >= this.numberOfLevels) {
			Debug.LogWarningFormat ("Invalid level index: {0}", level);
			return false;
		}

		this.currentLevel = level;
		return true;
	}

	/// <summary>
	/// Gets the current level.
	/// </summary>
	/// <returns>The current level.</returns>
	public int GetCurrentLevel() {
		return this.currentLevel;
	}
	#endregion
}
