﻿using UnityEngine;
using System.Collections;

public class removeobject : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		print (other.gameObject);
		if (other.gameObject.ToString().Contains("wood")) {
			//
		}
	}
}
