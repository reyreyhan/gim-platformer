using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScoreManager : MonoBehaviour {
	public static int shopScore;
	Text ShopScore;

	// Use this for initialization
	void Start () {
		ShopScore = GetComponent<Text> ();
		shopScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		ShopScore.text = "Shop Gold : " + shopScore;
	}
}
