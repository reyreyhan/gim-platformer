using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopNyawaManager : MonoBehaviour {
	public static int shopNyawa;
	Text ShopNyawa;
	// Use this for initialization
	void Start () {
		ShopNyawa = GetComponent<Text> ();
		shopNyawa = 30;
	}
	
	// Update is called once per frame
	void Update () {
		ShopNyawa.text = "Shop Nyawa  : " + shopNyawa;
	}
}
