using UnityEngine;
using System.Collections;

public class hammer2 : MonoBehaviour {

	// Use this for initialization
	Animator animator;

	void Start () {
		animator = GetComponent (typeof(Animator)) as Animator;
		animator.speed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
		//if (Input.anyKey) {
			animator.Play("hammer2animation", 0, 0.0f);
			animator.speed = 1;
		}
	}

}
