using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System.Threading;
using System;
using Object = System.Object;

public class BuyNyawa : MonoBehaviour {

    //public Button buttonNyawa;
    int x;
    bool status;
    //FileStream file = null;
    private static Object file = new Object();

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
        if(ScoreManager.score > 2)
        {
            NyawaManager.nyawa += 1;
            ScoreManager.score -= 3;
			ShopScoreManager.shopScore += 3;

            Debug.Log("Berhasil Beli");            
                           
        } else
        {
            Debug.Log("Gagal Beli");
        }

        
        /*try
        {
            lock(file) { 
                Thread T = new Thread(BuyNyawa.CreateThread);
                T.Start();
           
                var textFile = File.ReadAllText("E:/LogNyawa.txt");
                File.WriteAllText("E:/LogNyawa.txt", textFile + "Nyawa Sekarang Adalah : " + NyawaManager.nyawa + "\r\n");
            }
        }
        catch(Exception e)
        {
            Debug.Log("Thread Gagal di Buat");   
        }*/
    }

    public static void CreateThread()
    {
        /*int urutanID = Thread.CurrentThread.ManagedThreadId;
        int threadID = (int)AppDomain.GetCurrentThreadId();
        
        var textUrutanID = File.ReadAllText("E:/ThreadID.txt");
        File.WriteAllText("E:/ThreadID.txt", textUrutanID + "Urutan ke : " + urutanID + "\r\n");

        var textThreadID = File.ReadAllText("E:/ThreadID.txt");
        File.WriteAllText("E:/ThreadID.txt", textThreadID + "Thread ID : " + threadID + "\r\n\r\n");*/

    }
}
