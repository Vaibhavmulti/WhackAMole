using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    private TextMesh text;
    private float startTimer = 3f;

    public static bool gameStarted=false;
    // Use this for initialization
    private void Awake()
    {
        gameStarted = false;
        startTimer = 3.9f;
    }

    void Start () {
        text = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        if (startTimer <= 0.5f)
        {
            gameStarted = true;
            text.gameObject.SetActive(false);
        }
        else
        {
            startTimer -= Time.deltaTime;
            text.text = Mathf.Floor(startTimer).ToString();
        }
	}
}
