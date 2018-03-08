using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Collision : MonoBehaviour {

    public int nyawa = 1;
    public int score = 0;
    public static int character = 0;
    public Sprite newCharacter;
    private SpriteRenderer sp;

    //Text text;

    public GameObject KarakterUtama;

    // Use this for initialization
    void Start () {
        character = 0;
		KarakterUtama = GameObject.Find("KarakterUtama");
        //text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (NyawaManager.nyawa <= 0)
        {
            Destroy(KarakterUtama);
            Debug.Log("Kamu Kalah");
        }

        if(character == -1)
        {
            sp = gameObject.GetComponent<SpriteRenderer>();
            sp.sprite = newCharacter;
        }

//        text.text = "Score: " + score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.name == "Karakter")
        {
            NyawaManager.nyawa -=  1;
        }

        if(collision.gameObject.name == "Box")
        {
            score = score + 1;
            Destroy(collision.gameObject);
            Debug.Log("Score : " + score);
            ScoreManager.score += 100;
        }

        if (collision.gameObject.name == "Box1")
        {
            score = score + 1;
            Destroy(collision.gameObject);
            Debug.Log("Score : " + score);
            ScoreManager.score += 10;
        }

 
		if (collision.gameObject.name == "Box2")
        {
            score = score + 1;
            Destroy(collision.gameObject);
            Debug.Log("Score : " + score);
            ScoreManager.score += 10;
        }

		if (collision.gameObject.name == "Box3")
		{
			score = score + 1;
			Destroy(collision.gameObject);
			Debug.Log("Score : " + score);
			ScoreManager.score += 10;
		}

		if (collision.gameObject.name == "Box4")
		{
			score = score + 1;
			Destroy(collision.gameObject);
			Debug.Log("Score : " + score);
			ScoreManager.score += 10;
		}

		if (collision.gameObject.name == "Box5")
		{
			score = score + 1;
			Destroy(collision.gameObject);
			Debug.Log("Score : " + score);
			ScoreManager.score += 10;
		}

		if (collision.gameObject.name == "Box6")
		{
			score = score + 1;
			Destroy(collision.gameObject);
			Debug.Log("Score : " + score);
			ScoreManager.score += 10;
		}

		if (collision.gameObject.name == "Box7")
		{
			score = score + 1;
			Destroy(collision.gameObject);
			Debug.Log("Score : " + score);
			ScoreManager.score += 10;
		}

		if(collision.gameObject.name == "pumkin2")
        {
            character += 1;
            Debug.Log("Score Berubah : " + character);
            Destroy(collision.gameObject);
        }
    }
}