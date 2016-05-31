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

	string txt = "";
	string[] arrtxt;
	public static float cnt = 0;

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
		//float bpm = 150;
		//float[] humen = {0,1,1,0,1,1,2,2,1,2,2,0,1,1,2,2,1,2,2,0};
		FileInfo fi = new FileInfo(Application.dataPath + "/" + "test.txt");
		try {
			// 一行毎読み込み
			using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8)){
				txt = sr.ReadToEnd();
				arrtxt = txt.Split(',');
			}
		} catch (Exception e){
			// 改行コード
			//guitxt += SetDefaultText();
		}
		//print (arrtxt[0]);
		float bpm = float.Parse(arrtxt[0]);
		//print (arrtxt[1]);
		string[] humen = new string	[arrtxt[1].Length];
		for (int i = 0; i < arrtxt[1].Length; i++) humen[i] = arrtxt[1].Substring(i, 1);
		//print (bpm);
		//print (humen[1]);
		createhumen (bpm, humen);
	}

	void createhumen(float bpm, string[] arr) {
		float j = 0;
		float kugikankaku = 2 * 60 / bpm;
		float x = 4*2*60/bpm;
		foreach (string i in arr)
		{
			int h = int.Parse (i);
			if (j % 4 == 0) {
				// wood作成
				w = (GameObject)Instantiate (wood, new Vector3(-(x/2)-(x*j/4), 0.5f, 0), Quaternion.identity);
				w.transform.parent = RaneController.transform;
				w.transform.localScale = new Vector3(x, 1, 1);
			}
			//print (i);
			if (h == 1) {
				cnt++;
				// kugi作成
				k = (GameObject)Instantiate (kugi, new Vector3((-1-j)*kugikankaku, 1, 0), Quaternion.identity);
				k.transform.parent = RaneController.transform;
			}else if(h == 2){
				cnt++;
				// ookii kugi
				k = (GameObject)Instantiate (kugi, new Vector3((-1-j)*kugikankaku, 1.25f, 0), Quaternion.identity);
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
