using UnityEngine;
using System.Collections;

public class BulletBattery : MonoBehaviour {
	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")) {
		Debug.Log ("fire");
			Instantiate(bullet, transform.position, transform.rotation);
		}
	}
}
