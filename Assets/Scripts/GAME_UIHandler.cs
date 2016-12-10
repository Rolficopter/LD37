using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAME_UIHandler : MonoBehaviour {

    public Text currentLevelTxt;
    public Text enemiesKilledTxt;
	
    public void updateText()
    {
        currentLevelTxt.text = "Current Level: " + GAME_GameManager.getCurrentLevel().ToString();
        enemiesKilledTxt.text = "Enemies Killed: " + GAME_GameManager.getEnemiesKilled().ToString();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
