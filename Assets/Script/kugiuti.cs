﻿using UnityEngine;
using System.Collections;

public class kugiuti : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("kugi")) {
			other.gameObject.transform.position += new Vector3 (0f, -0.45f, 0f);
			//Destroy(other.gameObject);
			//gameObject.transform.position = Vector3.up * 5;
		}
	}
}
