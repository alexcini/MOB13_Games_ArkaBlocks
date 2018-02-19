using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {

	public float speed;


	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxisRaw("Horizontal");
		GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;

			
	}
}
