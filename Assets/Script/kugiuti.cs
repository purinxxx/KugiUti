using UnityEngine;
using System.Collections;

public class kugiuti : MonoBehaviour {
	public static float result = 0;

	//static int cnt;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		//print (humen.cnt);
		if (other.gameObject.CompareTag ("kugi")) {
			result++;
			print(100*result/humen.cnt);
			if (other.gameObject.transform.position.y == 1.25f) {
				//ookii kugi
				other.gameObject.transform.position += new Vector3 (0f, -0.7f, 0f);
			} else if (other.gameObject.transform.position.y == 1) {
				other.gameObject.transform.position += new Vector3 (0f, -0.45f, 0f);
			}
			//Destroy(other.gameObject);
			//gameObject.transform.position = Vector3.up * 5;
		}
	}
}
