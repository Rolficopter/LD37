using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour {

	private GameObject text;

	void Start() {
		text = GameObject.Find ("Loading Text");
		text.SetActive (false);
	}

	public void StartGame()
    {
		text.SetActive (true);
		var textAnimation = text.GetComponent<Animation> ();
		textAnimation.Play ("Text_fade");

		SceneManager.LoadSceneAsync ("Room", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
