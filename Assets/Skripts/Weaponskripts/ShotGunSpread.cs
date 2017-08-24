using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunSpread : MonoBehaviour {
    public float     MaxSpread;
    public bool      Inverted;
   
	// Use this for initialization
	void Start () {
        if(!Inverted)
        {
            transform.Rotate(0, Random.Range(5f, MaxSpread), 0);
        }
        else
        {
            transform.Rotate(0, -Random.Range(5f, MaxSpread), 0);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
