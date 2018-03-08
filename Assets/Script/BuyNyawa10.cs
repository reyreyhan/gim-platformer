using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System.Threading;
using System;

public class BuyNyawa10 : MonoBehaviour {

    //public Button buttonNyawa;


    // Use this for initialization
    void Start()
    {

        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        if (ScoreManager.score > 20)
        {
            NyawaManager.nyawa += 10;
            ScoreManager.score -= 20;
			ShopScoreManager.shopScore += 20;

            Debug.Log("Berhasil Beli");
        }
        else
        {
            Debug.Log("Gagal Beli");
        }


    }
}
