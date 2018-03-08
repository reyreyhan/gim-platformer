using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NyawaManager : MonoBehaviour {
    public static int nyawa;
    Text Nyawa;

	// Use this for initialization
	void Start () {
        Nyawa = GetComponent<Text>();
        nyawa = 2;
	}
	
	// Update is called once per frame
	void Update () {
        Nyawa.text = "Nyawa : " + nyawa;
    }
}
