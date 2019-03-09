using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndTime1 : MonoBehaviour {
    private GameControllerMod gamecontroller;

    public TextMesh textMesh;
	// Use this for initialization
	void Start () {
        gamecontroller = GameObject.FindObjectOfType<GameControllerMod>();
	}
	
	// Update is called once per frame
	void Update () {
        textMesh.text = "         Hit em' all!! \n\n" + "  Time :" +Mathf.Floor(gamecontroller.checkGameTimer) +"\n  Score :" +DetectAMole.score;
	}
}
