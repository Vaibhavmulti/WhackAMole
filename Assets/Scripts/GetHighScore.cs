using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour {
    Text highscore;
	// Use this for initialization
	void Start () {
        highscore = GetComponent<Text>();
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highscore.text = "HighScore: "+PlayerPrefs.GetInt("HighScore").ToString();
        }
	}
}
