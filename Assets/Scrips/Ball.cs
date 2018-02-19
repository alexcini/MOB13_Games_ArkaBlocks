using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	public float speed; 

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.up * speed;
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth){
		return (ballPos.x - racketPos.x) / racketWidth;
	}

	void OnCollisionEnter2D(Collision2D col) {

			Debug.Log(col.gameObject.name);
		
		//Colisão na racket
		if (col.gameObject.name == "racket") {
			//Sound 
			SoundManager.Playsound("rackethit");

			//calculo do fator
			float x = hitFactor (transform.position,
				         col.transform.position,
				         col.collider.bounds.size.x);

			//calculo da direção
			Vector2 dir = new Vector2 (x, 1).normalized;

			//Determina a velocidade
			GetComponent<Rigidbody2D> ().velocity = dir * speed;

		}

		if (col.gameObject.name == "Bottom") {
			//GameOver
			SoundManager.Playsound("gameover");
			SceneManager.LoadScene ("GameOver");

		}


	}	
	// Update is called once per frame
	void Update () {
	}
}
