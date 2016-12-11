using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeShootingScript : MonoBehaviour {

	public Transform projectile;
	public float projectileSpeed = 5000;
	public Transform projectileSpawn;

	private float shootLimit;
    private float shootingLightDuration = 0.05f;

	private float lastShoot = 0;
	private bool shot = false;
    private bool lightOn = false;



	// Use this for initialization
	void Start () {
		shootLimit = FindObjectOfType<DudeShootAnimationScript> ().animationDuration;
	}

    // Update is called once per frame
    private float deltaTimeSum = 0f;
    void Update () {
        deltaTimeSum += Time.deltaTime;
		if (Input.GetButtonDown ("Fire1") && (Time.time > lastShoot + shootLimit || !shot)) {
            var lights = this.GetComponentsInChildren<Light>();
            foreach (Light light in lights) {
                Debug.Log(light.name);
                if (light.name.Equals("Point light")) {
                    light.intensity = 3f;
                    deltaTimeSum = 0f;
                    lightOn = true;
                }
            }
			Transform bullet = Instantiate(projectile, projectileSpawn.position, Camera.main.transform.rotation);
			//bullet.rotation = Quaternion.Euler(bullet.rotation.eulerAngles.x - 90, bullet.rotation.eulerAngles.y, bullet.rotation.eulerAngles.z);
			bullet.GetComponent<Rigidbody>().AddForce (bullet.transform.forward * projectileSpeed);
			Destroy (bullet.gameObject, 2);
			lastShoot = Time.time;
			shot = true;
		}
        if (lightOn && deltaTimeSum >= this.shootingLightDuration) {
            var lights = this.GetComponentsInChildren<Light>();
            foreach (Light light in lights)
            {
                if (light.name.Equals("Point light"))
                {
                    light.intensity = 0;                  
                }
            }

            lightOn = false;
        }
	}
}
