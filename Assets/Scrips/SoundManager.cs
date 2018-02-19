using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static AudioClip blockSound, racketSound;

	static AudioSource audioSrc;


	// Use this for initialization
	void Start () {
		blockSound = Resources.Load<AudioClip> ("blockhit");
		racketSound = Resources.Load<AudioClip> ("rackethit");
		racketSound = Resources.Load<AudioClip> ("gameover");
		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void Playsound (string clip) {

		switch (clip) {

		case "blockhit":
			audioSrc.PlayOneShot (blockSound);
			break;
		case "rackethit":
			audioSrc.PlayOneShot (racketSound);
			break;
		case "gameover":
			audioSrc.PlayOneShot (racketSound);
			break;

		}
	
	}
}
