using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour {

    public Text currentLevelTxt;
    public Text enemiesKilledTxt;
	
    public void updateText()
    {
        currentLevelTxt.text = "Current Level: " + GameManager.getCurrentLevel().ToString();
        enemiesKilledTxt.text = "Enemies Killed: " + GameManager.getEnemiesKilled().ToString();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
