using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAMole : MonoBehaviour {
    RaycastHit hit;
    public static int score = 0;
    // Use this for initialization
    private void Awake()
    {
        score = 0;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Physics.Raycast(transform.position,transform.forward,out hit);
        if(Input.GetButtonDown("Fire1") && hit.transform!=null)
        {
            if(hit.transform.gameObject.GetComponent<Mole>())
            {
                hit.transform.gameObject.GetComponent<Mole>().Hitted();
                GameObject.FindObjectOfType<Hammer>().HitAMole(hit.transform.position);
                score++;
            }
        }
	}
}
