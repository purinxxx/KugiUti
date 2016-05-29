using UnityEngine;
using System.Collections;
using System.IO; //System.IO.FileInfo, System.IO.StreamReader, System.IO.StreamWriter
using System; //Exception
using System.Text; //Encoding

public class humen : MonoBehaviour {
	GameObject RaneController;
	GameObject wood;
	GameObject kugi;
	GameObject w;
	GameObject k;

	// Use this for initialization
	void Start () {
		RaneController = GameObject.Find("RaneController");
		// プレハブを取得
		wood = (GameObject)Resources.Load ("Prefabs/wood");
		kugi = (GameObject)Resources.Load ("Prefabs/kugi");
		loadhumen ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void loadhumen() {
		float bpm = 150;
		float[] humen = {0,0,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1,1};
		createhumen (bpm, humen);
	}

	void createhumen(float bpm, float[] arr) {
		float j = 0;
		float kugikankaku = 2 * 60 / bpm;
		float x = 4*2*60/bpm;
		foreach (float i in arr)
		{
			if (j % 4 == 0) {
				// wood作成
				w = (GameObject)Instantiate (wood, new Vector3(-(x/2)-(x*j/4), 0.5f, 0), Quaternion.identity);
				w.transform.parent = RaneController.transform;
				w.transform.localScale = new Vector3(x, 1, 1);
			}
			//print (i);
			if (i == 1) {
				// kugi作成
				k = (GameObject)Instantiate (kugi, new Vector3((-1-j)*kugikankaku, 1, 0), Quaternion.identity);
				k.transform.parent = RaneController.transform;
			}
			j++;
		}
	}
}

/*
秒速=2でスクロール
泊=4

木の長さ
泊*秒速*60/bpm


釘の間隔
秒速*60/bpm


１小節の長さ
泊*60/bpm
*/