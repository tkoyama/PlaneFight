using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rotate ();
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

	void Rotate () {
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");
		transform.Rotate(new Vector3 (y, 0f, 0f));
		transform.Rotate(new Vector3 (0f, x, 0f), Space.World);
	}
}
