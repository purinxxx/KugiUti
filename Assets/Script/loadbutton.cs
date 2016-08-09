using UnityEngine;
using System.Collections;

public class loadbutton : MonoBehaviour {
	public static float kyoku = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SceneLoad () {
		Application.LoadLevel("play");
	}
	public void SceneLoad2 () {
		kyoku = 2;
		Application.LoadLevel("play");
	}
}
