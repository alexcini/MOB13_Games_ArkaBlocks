using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Placar : MonoBehaviour {
	public Text txtScore;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Main.score);
		txtScore.text = Main.score.ToString ();
	}
}
