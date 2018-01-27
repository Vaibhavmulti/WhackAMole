using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {
    private Vector3 target;
    private float timer;
    private bool spawned;

    public float hideDistance=-1.5f, showDistance=-0.26f;
    public float speed = 4f;
	// Use this for initialization
	void Start () {
        spawned = false;
        target = new Vector3(transform.localPosition.x,hideDistance,transform.localPosition.z);
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0 && spawned)
            Hide();
        transform.localPosition = Vector3.Lerp(transform.localPosition,target,speed * Time.deltaTime);
	}
    
    public void Spawn(float totalTime)
    {
        target = new Vector3(transform.localPosition.x, showDistance, transform.localPosition.z);
        timer = totalTime;
        spawned = true;
    }

    public void Hide()
    {
        target = new Vector3(transform.localPosition.x, hideDistance, transform.localPosition.z);
        spawned = false;
    }

}
