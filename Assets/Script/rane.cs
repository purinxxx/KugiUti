using UnityEngine;
using System.Collections;

public class rane : MonoBehaviour {
	bool onPlay = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && onPlay==false) {
			onPlay = true;
		}
		if (onPlay) {
			transform.position += new Vector3(2f*Time.deltaTime, 0f, 0f);
			// 秒速移動
			// 参考 http://vivi.dyndns.org/tech/cs/moveObject.html
		}
	}
}

/* 
todo
譜面データを読み込む
動的なノーツ/レーンの生成
画面外に出たノーツ/レーンを削除
mayaで3dモデル/テクスチャの作成
効果音・パーカッションの再生
演出の強化
スマホ対応
GUIの作成
お手つきした場合に木の表面に傷ついたテクスチャを付与？
*/