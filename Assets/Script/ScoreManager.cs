using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    //public static int nyawa;

    
    Text Score;
    //Text Nyawa;


    void Start()
    {
        Score = GetComponent<Text>();
        //Nyawa = GetComponent<Text>();
        
        score = 0;
        //nyawa = 2;
    }


    void Update()
    {   
        Score.text = "Gold : " + score;
        //Nyawa.text = "Nyawa : " + nyawa;
    }
}