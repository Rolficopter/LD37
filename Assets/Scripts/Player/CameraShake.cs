using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {
	public float shakeStrength = 5;
	public bool shaking = false;

	Vector3 originalPosition;

	void Start()
	{
		originalPosition = transform.localPosition;
	}

	void LateUpdate()
	{
		if (shaking) {
			Camera.main.transform.localPosition = originalPosition + (Random.insideUnitSphere * shakeStrength);
		} else {
			Camera.main.transform.localPosition = originalPosition;
		}
	}

	public void StartShake() {
		shaking = true;
	}

	public void StartShake(float seconds) {
		shaking = true;
		Invoke ("StopShake", seconds);
	}

	public void StopShake() {
		shaking = false;
	}
}
