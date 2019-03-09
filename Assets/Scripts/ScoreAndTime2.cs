using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndTime2 : MonoBehaviour {
    private GameControllerHard gamecontroller;

    public TextMesh textMesh;
	// Use this for initialization
	void Start () {
        gamecontroller = GameObject.FindObjectOfType<GameControllerHard>();
	}
	
	// Update is called once per frame
	void Update () {
        textMesh.text = "         Hit em' all!! \n\n" + "  Time :" +Mathf.Floor(gamecontroller.checkGameTimer) +"\n  Score :" +DetectAMole.score;
	}
}
