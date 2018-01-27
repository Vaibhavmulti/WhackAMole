using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSpawnRandom : MonoBehaviour {
    private Mole[] moles;
    private float timer = 0f;
    public float spawnTime=1.3f;
	// Use this for initialization
	void Start () {
        moles = GetComponentsInChildren<Mole>();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            moles[Random.Range(0, moles.Length)].Spawn(spawnTime);
            timer = spawnTime;
        }
	}
}
