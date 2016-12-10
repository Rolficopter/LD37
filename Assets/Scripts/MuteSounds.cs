using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSounds : MonoBehaviour {

    private bool muted;
    private float volume;

    // Use this for initialization
    void Start () {
        volume = AudioListener.volume;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.M))
        {
            muted = !muted;
            if (muted)
            {
                AudioListener.volume = 0f;
            }else
            {
                AudioListener.volume = volume;
            }
        }
	}
}
