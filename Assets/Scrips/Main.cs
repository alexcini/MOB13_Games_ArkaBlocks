using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Main : MonoBehaviour {

	public static int countBlocks;
	public static int score;

	// Use this for initialization
	void Start () {

		countBlocks = 41;
		score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("CountBlock = ");
		Debug.Log (countBlocks);
		Debug.Log ("Score      = "); 
		Debug.Log(score);

		if (Main.countBlocks <= 0) {
			SceneManager.LoadScene("GameOver");
		}
	}
}