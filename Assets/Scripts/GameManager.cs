using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool isGamePaused;
	private int enemiesKilled;

	void Start () {
		isGamePaused = false;
	}

	#region Pausing the Game
    /// <summary>
    /// Pauses the game.
    /// </summary>
    public void PauseGame() {
		this.isGamePaused = true;
    }

    /// <summary>
    /// Resumes the game.
    /// </summary>
    public void ResumeGame() {
		this.isGamePaused = false;
    }

	/// <summary>
	/// Determines whether this instance is game paused.
	/// </summary>
	/// <returns><c>true</c> if this instance is game paused; otherwise, <c>false</c>.</returns>
	public bool IsGamePaused() {
		return this.isGamePaused;
	}
	#endregion

	#region Kill Count
	/// <summary>
	/// Sets the enemies killed.
	/// </summary>
	/// <param name="v">V.</param>
	public void setEnemiesKilled(int v) {
		enemiesKilled = v;
	}

	/// <summary>
	/// Gets the enemies killed.
	/// </summary>
	/// <returns>The enemies killed.</returns>
	public int getEnemiesKilled() { return enemiesKilled; }
	#endregion
}
