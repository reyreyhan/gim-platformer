using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCharacter : MonoBehaviour {
    public Sprite char1;

	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClick()
    {
        if (Collision.character > 0 && ScoreManager.score > 49)
        {

            Collision.character -= 2;
            ScoreManager.score -= 50;
            Debug.Log("Berhasil Ganti Character : " + Collision.character);
            
        }
    }
}
