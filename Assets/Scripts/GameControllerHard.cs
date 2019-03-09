using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerHard : MonoBehaviour {
    private Mole[] moles;
    private float timer;
    private float waitForGameReload;

    public float checkGameTimer;
    public GameObject moleHolder;
    public float gameTimer=15f;
    public float spawnTime=1.5f;
    public float minSpawnTime=0.5f;
    public float spawnTimeDecrementer=0.1f;

    private void Awake()
    {
        timer = 0f;
        waitForGameReload = 3f;
        checkGameTimer=gameTimer;
    }
    // Use this for initialization
    void Start () {
        moles = moleHolder.GetComponentsInChildren<Mole>();
	}
	
	// Update is called once per frame
	void Update () {
        if(StartGame.gameStarted)
        {
            if (checkGameTimer > 0.2)
            {
                checkGameTimer -= Time.deltaTime;
                timer -= Time.deltaTime;
                if (timer <= 0f)
                {
                    moles[Random.Range(0, moles.Length)].Spawn(spawnTime);
                    timer = spawnTime;
                    spawnTime -= spawnTimeDecrementer;
                    if (spawnTime <= minSpawnTime)
                        spawnTime = minSpawnTime;
                }
            }
            else
            {
                checkGameTimer = 0f;
                waitForGameReload -= Time.deltaTime;
                if (waitForGameReload < 0)
                {
                    waitForGameReload = 3f;
                    checkGameTimer = gameTimer;
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
	}
}
