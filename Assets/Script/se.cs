using UnityEngine;
using System.Collections;

public class se : MonoBehaviour {

	public AudioClip audioClip;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("kugi")) {
			audioSource.Play ();
		}
	}
}
