using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	bool onPlay = false;
	public AudioClip audioClip;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && onPlay==false) {
			onPlay = true;
			audioSource.Play();
		}
	}
}
