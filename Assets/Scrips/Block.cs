﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col) {
		Destroy (gameObject);
		SoundManager.Playsound("blockhit");
		Main.score += 10;
		Main.countBlocks -= 1;
	}
}
