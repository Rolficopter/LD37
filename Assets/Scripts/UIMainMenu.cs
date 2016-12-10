using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour {

	public void StartGame()
    {
		SceneManager.LoadSceneAsync ("Room", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
