using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StepScenes : MonoBehaviour {

	public string scene;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			Debug.Log (scene);
			SceneManager.LoadScene("ArkanoidScenes");
		}
		
	}
}
