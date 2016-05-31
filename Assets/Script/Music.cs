using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	bool onPlay = false;
	float duration;
	float cnt;
	public AudioClip audioClip;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		duration = 0;
		cnt = -60;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && onPlay==false) {
			onPlay = true;
			audioSource.Play();
		}
		if (onPlay) {
			cnt++;
			duration += Time.deltaTime;
			//print (duration);
			//print (cnt);
		}
	}

}