using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
	public int speed = 10;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
