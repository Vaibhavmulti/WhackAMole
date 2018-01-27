using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour {
    TextMesh text;
    // Use this for initialization
    private void Awake()
    {
        text = GetComponent<TextMesh>();
    }
    void Start () {
        text.text ="Score :"+  DetectAMole.score.ToString();
        if(PlayerPrefs.HasKey("HighScore"))
        {
            if (PlayerPrefs.GetInt("HighScore") < DetectAMole.score)
                PlayerPrefs.SetInt("HighScore",DetectAMole.score);
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", DetectAMole.score);
        }
	}
}
